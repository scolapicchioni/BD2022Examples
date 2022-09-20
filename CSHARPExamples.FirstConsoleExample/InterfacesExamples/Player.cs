using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InterfacesExamples {
    public class Player {
        private readonly IDice dice;
        //dependency injection
        public Player(IDice dice) {
            this.dice = dice;
        }

        public int Score { get; private set; }
        public void Play() {
            Score = dice.Roll() + dice.Roll();
        }
    }
}
