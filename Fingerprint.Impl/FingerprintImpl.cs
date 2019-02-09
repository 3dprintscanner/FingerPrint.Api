using SourceAFIS.Simple;
using System;
using System.IO;

namespace Fingerprint.Impl
{
    public class FingerPrintImpl
    {

        public string DoFingerPrint(Stream stream)
        {

            AfisEngine Afis = new AfisEngine();

            var fs = new SourceAFIS.Simple.Fingerprint();

            fs.AsBitmap = new System.Drawing.Bitmap(stream);


            var person = new Person();
            person.Fingerprints.Add(fs);

            Afis.Extract(person);

            return person.Fingerprints[0].AsXmlTemplate.ToString();

        }
    }
}
