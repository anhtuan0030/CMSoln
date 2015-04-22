using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class TeacherService: ITeacherService
    {
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public TeacherService()
        {
            ParseObject.RegisterSubclass<Teachers>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }

        public async Task<IEnumerable<ITeachers>> GetTeachers()
        {
            var query = new ParseQuery<Teachers>();

            var result = await query.FindAsync();

            return result;
        }

        public async Task<ITeachers> GetTeachers()
        {
            var query = new ParseQuery<Teachers>();

            

            //var query = 
            //from userTable in ParseUser.Query
            //where contactNumbers.Contains( userTable.Get<string>("mobile") )
            //select userTable;

            var result = await query.FirstOrDefaultAsync();

            return result;
        }

    }
}
