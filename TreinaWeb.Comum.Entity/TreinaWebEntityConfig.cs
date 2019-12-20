using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Comum.Entity
{
    public abstract class TreinaWebEntityConfig<TEntidade> : EntityTypeConfiguration<TEntidade> where TEntidade : class
    {
        public TreinaWebEntityConfig()
        {
            ConfigurarNome();
            ConfigurarCampo();
            ConfigurarPK();
            ConfigurarFK();
        }

        protected abstract void ConfigurarFK();
        

        protected abstract void ConfigurarPK();


        protected abstract void ConfigurarCampo();       

        protected abstract void ConfigurarNome();
        
    }
}
