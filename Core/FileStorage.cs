using System;
using System.IO;
using System.Text;

namespace Core
{
    public class FileStorage
    {
        /*
        * Metodo para criar diretorios e arquivos a partir da passagem de parametros
        * path, filename, extension e content.
        *
        */
        public static void createFolderAndFile(string path, string filename, string extension, string content)
        {
            string storageDir = @$"storage\{path}\";
            try
            {
                if (!Directory.Exists(storageDir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(storageDir);
                }

                // Cria arquivo ou sobrescreve existente (se nao quiser que sobrescreva basta verificar existencia com File.Exists(path)).
                using (FileStream fs = File.Create(storageDir + filename + extension))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(content);
                    // escreve o conteúdo no arquivo.
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}