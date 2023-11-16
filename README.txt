


Design and Assumptions:
The self-driving car prototype is designed in C# using a simple command-based approach. 
The car has a set of commands (L, R, F) to rotate left, rotate right, and move forward, respectively. 
The program processes these commands to update the car's position and facing direction on a rectangular field. 
Assumptions include a field represented by width and height, and the car cannot move beyond the field boundaries.

Code: csharp

Interfaces:
  1. public interface IVehicle
    {        
        char dir { get; set; }            
        string GetCurrentLocation();
        IDriver Driver { get; set; }
        public IAreaMap Location { get; set; }
    }
 2. public interface IAreaMap
    {
        int areaWidth { get; set; }
        int areaHeight { get; set; }
        int CarXCoordinate { get; set; }
        int CarYCoordinate { get; set; }
        string GetCarLocation();
        void SetCarLocation(char carLocation);
    }
  3.  public interface IDriver
    {
        void Drive(string? directions);
    }
 
 Implementation Classes:
    1. AreaMap Class - Implements the IAreaMap which handle the location the of the Car Object
    2. Car Class - Implements the IVehicle Inteface which take the Car object and holds its direction.
    3. Driver - Implements the IDriver Interface which handle the manipulation of car direction based on the given commands.

Instructions:

Environment: Run on Windows

Ensure you have .NET Core installed on your machine.

Library Installation:
No additional libraries are required for this simple prototype.

Compile and Run:
Open a terminal or command prompt.
Navigate to the directory containing C# files (\NCS_Car_Test).
Compile the code using the command: dotnet build --configuration Release
Run the executable: NCS_Car_Test\NCS_Test\bin\Release\net6.0\NSC_Car.exe

Input Format:

Provide input in the following format: 
	Area Size (ex. 10 10): 10 10
	Car Initial Position (ex. 1 1): 1 1
	Car Initial Direction (ex. N, E, S, or W): N
	Car Drive directions (ex. RLF): RLF

Output:
  Current Position: 1 2 N