using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDtoEntities.Datos;
using TestDtoEntities.DTO;
using TestDtoEntities.Modelo;

namespace TestDtoEntities.Logica
{
    public class DetalleBloombergLogica
    {

        #region Conversiones
        internal static DetalleBloombergDTO ConvertirDatosDetBloombergADTO(DetalleBloombergBE detBlommbergBE)
        {
            return new DetalleBloombergDTO
            {
                CodEncabloombergV = detBlommbergBE.CodEncabloombergV,
                CodEstadoN = detBlommbergBE.CodEstadoN,
                CodFieldV = detBlommbergBE.CodFieldV,
                CodRegistroN = detBlommbergBE.CodRegistroN,
                FecTransaccion = detBlommbergBE.FecTransaccion,
                ValBloombergN = detBlommbergBE.ValBloombergN
            };
        }

        internal static DetalleBloombergBE ConvertirDTODetBloombergADatos (DetalleBloombergDTO detalle)
        {
            return new DetalleBloombergBE
            {
                CodEncabloombergV = detalle.CodEncabloombergV,
                CodEstadoN = detalle.CodEstadoN,
                CodFieldV = detalle.CodFieldV,
                CodRegistroN = detalle.CodRegistroN,
                FecTransaccion = detalle.FecTransaccion,
                ValBloombergN = detalle.ValBloombergN
            };
        }
        #endregion
        public List<BaseDTO> ListarDetalleValoresBloomberg()
        {
            List<BaseDTO> respuesta = new List<BaseDTO>();
            try
            {
                DetalleBloombergDatos intermedioDatos = new DetalleBloombergDatos();

                var respDatos = intermedioDatos.ListarDetalleValoresBloomberg();
                if (respDatos.CodigoRespuesta == 1)
                {
                    var lista = ((List<DetalleBloombergBE>)respDatos.ContenidoRespuesta);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        respuesta.Add(ConvertirDatosDetBloombergADTO(lista[i]));
                    }
                    return respuesta;
                }
                else
                {
                    respuesta.Clear();
                    respuesta.Add((ErrorDTO)respDatos.ContenidoRespuesta);
                    return respuesta;
                }
            }
            catch (Exception error)
            {
                respuesta.Clear();
                respuesta.Add(new ErrorDTO { MensajeError = error.Message });
                return respuesta;
            }
        }
    }
}
