using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IStadiumCommandText
    {
        string GetAllStadiums { get; }
        string GetStadiumsById { get; }

        string AddStadiums { get; }
        string UpdateStadiums { get; }

        string DeleteStadiums { get; }
         
    }

    public class StadiumCommandText : IStadiumCommandText
    {
        public string GetAllStadiums =>
             "SELECT * FROM Stadium";

        public string GetStadiumsById =>
            "SELECT * FROM Stadium WHERE StadiumId=@StadiumId";

        public string AddStadiums =>
            "INSERT INTO Stadium (StadiumId ,StadiumName , StadiumPlace) Values(@StadiumId ,@StadiumName , @StadiumPlace )";

        public string UpdateStadiums =>
            "UPDATE Stadium SET StadiumName=@StadiumName , StadiumPlace=@StadiumPlace WHERE StadiumId=@StadiumId  ";

        public string DeleteStadiums =>
            "DELETE FROM  Stadium WHERE StadiumId=@StadiumId ";
    }
}
