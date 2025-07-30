using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppGestionAcademica
{
    public class cLogicaBD
    {
        SqlConnection OConexionBD;
        /* Constructor */
        public cLogicaBD(SqlConnection OConexionBD_)
        {
            OConexionBD = OConexionBD_;
        }
        /* Método para ejecutar procedimientos almacenados */
        /* ************************************************************** */
        public DataSet ProcedimientoAlmacenado(String NombreSP, out Exception Error, params Object[] Parametros)
        {	// ***** Recupera datos mediante un Procedimiento almacenado
            //       Los parametros se pasan como una lista de Objetos
            try
            {
                if (OConexionBD.State == ConnectionState.Closed)
                    OConexionBD.Open();

                // ----- Crear Objeto Command 
                SqlCommand OComandoSQL = new SqlCommand(NombreSP, OConexionBD);

                // ----- Indicar que el tipo de comando es de tipo Procedimiento Almacenado                
                /*
                OComandoSQL.Connection = OConexionBD;
                OComandoSQL.CommandText = NombreSP;
                */
                OComandoSQL.CommandType = System.Data.CommandType.StoredProcedure;
                // ----- Recuperar Parametros del procedimiento almacenado (implica una llamada adicional a la BD)
                SqlCommandBuilder.DeriveParameters(OComandoSQL);
                // ----- Cargar Parametros al Objeto SqlCommand 
                for (int K = 0; K < Parametros.Length; K++)
                    OComandoSQL.Parameters[K + 1].Value = Parametros[K];
                // ----- Se recupera un conjunto de datos                
                SqlDataAdapter ODataAdapter = new SqlDataAdapter();
                ODataAdapter.SelectCommand = OComandoSQL;
                DataSet ODataSet = new DataSet();
                ODataAdapter.Fill(ODataSet);
                OConexionBD.Close();
                Error = null;
                return ODataSet;
            }
            catch (Exception Error1)
            {
                DataSet dataSet1 = new DataSet();
                Error = Error1;
                return null;
            }
        }

        /* ************************************************************** */
        public DataSet ProcedimientoAlmacenado(String NombreSP, params Object[] Parametros)
        {   // ***** Recupera datos mediante un Procedimiento almacenado
            Exception Error = null;
            return ProcedimientoAlmacenado(NombreSP, out Error, Parametros);
        }
    }
}
