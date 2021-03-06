/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Easy.Web.Page
{
    public class HtmlStringWriter : TextWriter, IHtmlString
    {
        private readonly TextWriter _writer;

        public HtmlStringWriter()
        {
            _writer = new StringWriter();
        }

        public override Encoding Encoding
        {
            get { return _writer.Encoding; }
        }

        public string ToHtmlString()
        {
            return _writer.ToString();
        }

        public override string ToString()
        {
            return _writer.ToString();
        }

        public override void Write(string value)
        {
            _writer.Write(value);
        }

        public override void Write(char value)
        {
            _writer.Write(value);
        }
    }
}
