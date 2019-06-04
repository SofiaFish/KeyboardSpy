using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyboardSpy.Methods
{
    public class FileManager
    {
        public static async void Write(string file)
        {
            FileStream fStream =
                new FileStream("Test.txt", FileMode.Create,
                FileAccess.ReadWrite, FileShare.None, 4096, true);
            
            IAsyncResult asyncResult = fStream.BeginWrite(
                writeArray, 0, writeArray.Length,
                new AsyncCallback(EndWrite),
                fStream);
        }

        static void EndWrite(IAsyncResult asyncResult)
        {
            FileStream fStream = (FileStream)asyncResult.AsyncState;
            fStream.EndWrite(asyncResult);
            fStream.Close();
        }
    }
}
