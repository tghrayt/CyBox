using CyBox.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyBox.DAO.IDao
{
    public interface IRoleDao
    {
        public Task<IList<Role>> GetRoles();
        public Task<Role> GetRoleById(int idRole);
        public Task<Role> SaveRole(Role role);
    }
}
