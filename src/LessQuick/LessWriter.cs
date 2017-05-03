using System;
using System.IO;

namespace LessQuick {
    public class LessWriter : IDisposable {

        private TextWriter _writer;

        public LessWriter(TextWriter writer) {
            _writer = writer;
        }

        public LessWriter WriteId(string id) {
            _writer.Write('#');
            _writer.Write(id);
            return this;
        }

        public LessWriter WriteElementName(string elementName) {
            _writer.Write(elementName);
            return this;
        }

        public void WriteUniversalSelector() {
            _writer.Write('*');
        }

        public LessWriter WriteStartBlock() {
            _writer.Write("{\r\n");
            return this;
        }

        public LessWriter WriteEndBlock() {
            _writer.Write("}\r\n");
            return this;
        }

        public LessWriter WriteComma() {
            _writer.Write(", ");
            return this;
        }

        public void Dispose() {
            _writer.Dispose();
        }
    }
}
