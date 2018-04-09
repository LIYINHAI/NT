using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT.Models;
using NT.IDAL;
using NT.DALFactory;
using System.Data;
using System.Configuration;
namespace NT.BLL
{
   public class CullService
    {
        private static ICulinfo icomments = DataAccess.CreateCulinfo();
    }
}
