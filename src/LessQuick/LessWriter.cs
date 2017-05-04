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

        public void WriteVariableName(string name) {
            _writer.Write('@');
            _writer.Write(name);
        }

        public void WriteMixinName(string name) {
            _writer.Write('@');
            _writer.Write(name);
        }

        public void Write(char v) {
            _writer.Write(v);
        }

        public void Write(string v) {
            _writer.Write(v);
        }

        public void WriteLine(string v) {
            _writer.WriteLine(v);
        }

        public void WriteUniversalSelector() {
            _writer.Write('*');
        }

        public LessWriter WriteOperator(string @operator) {
            _writer.Write(' ');
            _writer.Write(@operator);
            _writer.Write(' ');
            return this;
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
