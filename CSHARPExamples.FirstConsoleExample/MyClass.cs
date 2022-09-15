using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    /// <summary>
    /// This class is responsible of doing things, very important things.
    /// </summary>
    public class MyClass {
        /// <summary>
        /// This is an awesome method
        /// </summary>
        /// <param name="someParameter">Some integer with a number</param>
        /// <returns>The number but then as a string!</returns>
        public string MyMethod(int someParameter) {
            if (someParameter > 100) {
                //ArgumentException argumentException;
                //argumentException = new ArgumentException($"I don't like your value! {someParameter}", "someParameter");
                //throw argumentException;

                //ArgumentException argumentException = new ArgumentException($"I don't like your value! {someParameter}", "someParameter");
                //throw argumentException;

                throw new ArgumentException($"I don't like your value! {someParameter}", "someParameter");
            }
            return someParameter.ToString();
        }
    }
}
