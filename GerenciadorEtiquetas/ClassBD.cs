using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace GerenciadorEtiquetas
{
    class ClassBD
    {
        private static FbConnectionStringBuilder conn = null;
        FbConnection con;

        #region ObterConexaoSJC
        public FbConnection obterConexaoSJC()
        {
            conn = new FbConnectionStringBuilder();
            conn.DataSource = "//192.168.10.9";
            conn.Port = 3050;
            conn.Database = "192.168.10.9:/home/dados/MSYSDADOS.FDB";
            conn.UserID = "sysdba";
            conn.Password = "masterkey";
            conn.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(conn.ToString());
            return db;
        }
        #endregion

        #region ObterConexaoSPM
        public FbConnection obterConexaoSPM()
        {
            conn = new FbConnectionStringBuilder();
            conn.DataSource = "//192.168.10.9";
            conn.Port = 3050;
            conn.Database = "192.168.10.9:/home/dadosmg/MSYSDADOS.FDB";
            conn.UserID = "sysdba";
            conn.Password = "masterkey";
            conn.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(conn.ToString());
            return db;
        }
        #endregion

        #region BuscaInfoEtiqueta
        public DataTable BuscaInfoEtiqueta(string CodProduto)
        {
            DataTable dtRes = new DataTable();
            try
            {
                con = obterConexaoSJC();
                con.Open();
                FbCommand cmd = new FbCommand("select p.pro_codigo, p.pro_barra, p.pro_resumo from produtos p where p.pro_codigo='" + CodProduto + "'", con);
                dtRes.Load(cmd.ExecuteReader());
                return dtRes;
            }
         catch (Exception ex)
            {
                string a = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
