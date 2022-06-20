using backend.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IStadiumRepository
    {
        List<Stadium> GetAllStadiums();
        Stadium GetStadiumsById(int StadiumId);

        void AddStadiums(Stadium stadium);
        void UpdateStadiums(Stadium stadium);
        void DeleteStadiums(int StadiumId);

    }

    public class StadiumRepository : IStadiumRepository
    {
        private readonly IStadiumCommandText _stadiumCommandText;

        private readonly string _connectionString;



        public StadiumRepository(IConfiguration configuration, IStadiumCommandText stadiumCommandText)
        {
            _stadiumCommandText = stadiumCommandText;
            _connectionString = configuration.GetConnectionString(name: "Dapper");

        }


        public void AddStadiums(Stadium stadium)
        {
            ExecuteCommand(_connectionString,
                conn => conn.Query<Stadium>(_stadiumCommandText.AddStadiums,
                new { StadiumId = stadium.StadiumId, StadiumName = stadium.StadiumName, StadiumPlace = stadium.StadiumPlace}));
        }


        public void DeleteStadiums(int StadiumId)
        {
            ExecuteCommand(_connectionString,
      conn =>
      {
          var query = conn.Query<Stadium>(_stadiumCommandText.DeleteStadiums,
              new { StadiumId = StadiumId });
      });
        }

        public List<Stadium> GetAllStadiums()
        {
            var query = ExecuteCommand(_connectionString, conn => conn.Query<Stadium>(_stadiumCommandText.GetAllStadiums)).ToList();
            return query;
        }

        public Stadium GetStadiumsById(int StadiumId)
        {

            var query = ExecuteCommand<Stadium>(_connectionString, conn => conn.Query<Stadium>(_stadiumCommandText.GetStadiumsById, new { @StadiumId = @StadiumId }).SingleOrDefault());

            return query;
        }

        public void UpdateStadiums(Stadium stadium)
        {
            ExecuteCommand(_connectionString,
    conn => conn.Query<Stadium>(_stadiumCommandText.UpdateStadiums,
        new { StadiumName = stadium.StadiumName, StadiumPlace = stadium.StadiumPlace, StadiumId = stadium.StadiumId }));
        }

        #region Helpers

        private void ExecuteCommand(string connection, Action<SqlConnection> task)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                task(conn);
            }
        }
        private T ExecuteCommand<T>(string connection, Func<SqlConnection, T> task)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                return task(conn);
            }
        }
        #endregion
    }
}

