using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestTeamCityBuild.DataAccess;
using TestTeamCityBuild.Model;

namespace TestTeamCityBuild.Web.Controllers
{
    public class BinaryFilesController : ApiController
    {
        private MyDbContext _db;

        public BinaryFilesController()
        {
            _db = new MyDbContext();
        }

        // GET api/BinaryFiles
        public IEnumerable<BinaryFile> Get()
        {
            return _db.BinaryFiles.ToList();
        }
    }
}