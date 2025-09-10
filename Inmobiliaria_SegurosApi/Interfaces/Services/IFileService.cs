using Inmobiliaria_SegurosApi.DTOs.Archivos;
using Inmobiliaria_SegurosApi.DTOs.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IFileService {
        Task<ResponseDTOs<ArchivoSubidoDTOs>> SubirArchivoAsync(SubirArchivoDTOs archivoDto);
        Task<ResponseDTOs<byte[]>> DescargarArchivoAsync(string rutaArchivo);
        Task<ResponseDTOs<bool>> EliminarArchivoAsync(string rutaArchivo);
        Task<ResponseDTOs<bool>> ValidarArchivoAsync(IFormFile archivo, string[] extensionesPermitidas, long tamañoMaximo);
        Task<ResponseDTOs<string>> GenerarNombreUnicoAsync(string nombreOriginal);
        Task<ResponseDTOs<bool>> ExisteArchivoAsync(string rutaArchivo);
        ResponseDTOs<string> GetMimeTypeAsync(string extension);
    }
}
