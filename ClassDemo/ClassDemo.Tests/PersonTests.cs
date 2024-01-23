using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Tests;

public class PersonTests
{
    [Fact]
    public void Constructor_ValidName_SuccessfulInitialization()
    {
        Person person = new();
    }

}
