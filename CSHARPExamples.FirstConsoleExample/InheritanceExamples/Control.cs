namespace CSHARPExamples.FirstConsoleExample.InheritanceExamples {
    internal abstract class Control {
        private int width;
        public int Width {
            get { return width; }
            set {
                if(value> 0)
                    width = value;
            }
        }
        public Control() {
            Console.WriteLine("New Control");
        }
        protected void Step01OfTheDraw() { 
            
        }
        public abstract void Draw();
    }
}
