using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDtoEntities.DTO;
using TestDtoEntities.Modelo;

namespace TestDtoEntities.Datos
{
    public class DetalleBloombergDatos : DataWorker
    {
        public RespuestaDTO  ListarDetalleValoresBloomberg()
        {
            try
            {
                #region Acceso a Datos
                List<DetalleBloombergBE> res = new List<DetalleBloombergBE>();
                string wsql = "select a.* " + Environment.NewLine +
                              " from IN_AMBDETABLOOMBERG a " + Environment.NewLine +
                              " where a.cod_encabloomberg_v = 'GT2' " + Environment.NewLine +
                              " and rownum = 1" + Environment.NewLine;

                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(wsql, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine(reader["DES_PERFIL"]);
                                DetalleBloombergBE pcBe = new DetalleBloombergBE()
                                {
                                    CodEncabloombergV = Convert.ToString(reader["COD_ENCABLOOMBERG_V"]),
                                    CodFieldV = Convert.ToString(reader["COD_FIELD_V"]),
                                    FecTransaccion = Convert.ToDateTime(reader["FEC_TRANSACCION"]),
                                    ValBloombergN = Convert.ToInt32(reader["VAL_BLOOMBERG_N"]),
                                    CodEstadoN = Convert.ToInt32(reader["COD_ESTADO_N"]),
                                    CodRegistroN = Convert.ToDecimal(reader["COD_REGISTRO_N"])
                                };
                                res.Add(pcBe);
                            }
                        }
                    }
                }
                #endregion

                if (res.Count > 0)
                {
                    return new RespuestaDTO
                    {
                        CodigoRespuesta = 1,
                        ContenidoRespuesta = res
                    };

                }
                else
                {
                    throw new Exception("No se encontró los datos Bloomberg [ListarDetalleValoresBloomberg]");
                }
            }
            catch (Exception error)
            {
                if (error.InnerException == null)
                {
                    return new RespuestaDTO
                    {
                        CodigoRespuesta = -1,
                        ContenidoRespuesta = new ErrorDTO { MensajeError = error.Message }
                    };
                }
                else
                {
                    return new RespuestaDTO
                    {
                        CodigoRespuesta = -1,
                        ContenidoRespuesta = new ErrorDTO { MensajeError = error.InnerException.Message }
                    };
                }
            }


        }
    }
}
