using CyBox.DAO.IDao;
using CyBox.Data.Context;
using CyBox.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyBox.DAO.Dao
{
    public class RoleDao : IRoleDao
    {

        private readonly CyBoxDbContext _cyBoxDbContext;

        public RoleDao(CyBoxDbContext cyBoxDbContext)
        {
            _cyBoxDbContext = cyBoxDbContext;
        }
    
        public async Task<Role> GetRoleById(int idRole)
        {
            try
            {
         
               var role = _cyBoxDbContext.Roles.FindAsync(idRole);
                return role.Result;

            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        public Task<IList<Role>> GetRoles()
        {
            throw new NotImplementedException();
        }

        public Task<Role> SaveRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
