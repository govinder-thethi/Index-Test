using System;
using System.Collections.Generic;
using System.linq;
using System.text;
using System.threading.tasks;

namespace TDD
{
    [Testfixture]
    public class Tokens
    {
        [Test]
        public void A()
        {
            var input = 
            @"
             _  _  _
            | || || |
            |_||_||_|

            ";

            var Tokens = Tokeniser.Tokenise(input);

        }
    }
}