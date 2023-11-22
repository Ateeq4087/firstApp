// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

car maruti = new car(new suzukiengine(new cylinder(new piston(), new crankshaft(new transmission()))));
car toyota = new car(new toyotaengine());
class car
{
    public car(IEnginevendor suzuki)
    {

    }
}
interface IEnginevendor { }
class suzukiengine : IEnginevendor 
{
    public suzukiengine(cylinder cylinder) 
    {

    }
}
class toyotaengine : IEnginevendor 
{
    
}
class piston
{ 
}
class cylinder 
{
    public cylinder(piston piston,crankshaft shaft)
    
    {

    }
}
class transmission { }
class crankshaft
{
    public crankshaft(transmission transmission)
    {

    }
}