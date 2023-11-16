using NSC_Car;
using NSC_Car.Interface;

namespace CarTest
{
    public class CarUnitTest
    {
        [Fact]
        public void RotateRightTest()
        {            
           IVehicle car = new Car(10, 10, 0, 0, 'N');
           car.Driver.Drive("R");
           Assert.Equal(@"0 0 E", car.GetCurrentLocation());
        }
        [Fact]
        public void RotateLeftTest()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'N');
            car.Driver.Drive("L");
            Assert.Equal(@"0 0 W", car.GetCurrentLocation());
        }
        [Fact]
        public void Rotate180LeftTest()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'N');
            car.Driver.Drive("LL");
            Assert.Equal(@"0 0 S", car.GetCurrentLocation());
        }

        [Fact]
        public void Rotate180RightTest()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'N');
            car.Driver.Drive("RR");
            Assert.Equal(@"0 0 S", car.GetCurrentLocation());
        }

        [Fact]
        public void TestForwardTest()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'N');
            car.Driver.Drive("F");
            Assert.Equal(@"0 1 N", car.GetCurrentLocation());
        }

        [Fact]
        public void TestForwardRotateLeftTest()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'N');
            car.Driver.Drive("FR");
            Assert.Equal(@"0 1 E", car.GetCurrentLocation());
        }

        [Fact]
        public void TestMultipleMoved()
        {
            IVehicle car = new Car(10, 10, 1, 2, 'N');
            car.Driver.Drive("FFRFFFRRLF");
            Assert.Equal(@"4 3 S", car.GetCurrentLocation());
        }        

        [Fact]
        public void TestInvalidCommand()
       {
            IVehicle car = new Car(10, 10, 1, 2, 'N');
            try
            {                
                car.Driver.Drive("W");
            }
            catch (Exception e)
            {
                Assert.Equal(@"Invalid direction.", e.Message);
            }            
        }
                
        [Fact]
        public void TestUpperLimtCommand()
        {
            IVehicle car = new Car(10, 10, 10, 0, 'N');
            try
            {
                car.Driver.Drive("F");
            }
            catch (Exception e)
            {
                Assert.Equal(@"Area upper limit reached", e.Message);
            }
        }
        
        [Fact]
        public void TestRigntLimtCommand()
        {
            IVehicle car = new Car(10, 10, 0, 10, 'E');
            try
            {
                car.Driver.Drive("F");
            }
            catch (Exception e)
            {
                Assert.Equal(@"Area right limit reached", e.Message);
            }
        }
        
        [Fact]
        public void TestLowerLimtCommand()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'S');
            try
            {
                car.Driver.Drive("F");
            }
            catch (Exception e)
            {
                Assert.Equal(@"Area lower limit reached", e.Message);
            }
        }
        
        [Fact]
        public void TestLeftLimtCommand()
        {
            IVehicle car = new Car(10, 10, 0, 0, 'W');
            try
            {
                car.Driver.Drive("F");
            }
            catch (Exception e)
            {
                Assert.Equal(@"Area left limit reached", e.Message);
            }
        }
    }


}