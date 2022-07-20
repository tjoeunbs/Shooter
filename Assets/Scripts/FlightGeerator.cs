using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlightGeerator
{
    public List<Flight> flights = new List<Flight>();
    
    public List<Flight> getFlights()
    {
        return flights;
    }

    public abstract void CreateFlight();
}

public class TriangleFlightGenerator : FlightGeerator
{
    public override void CreateFlight()
    {
        flights.Clear();
        flights.Add(new TriangleFlight());
        flights.Add(new TriangleFlight());
        flights.Add(new TriangleFlight());
    }
}

public class CicleFlightGenerator : FlightGeerator
{
    public override void CreateFlight()
    {
        flights.Clear();
        flights.Add(new CicleFlight());
        flights.Add(new CicleFlight());
        flights.Add(new CicleFlight());
    }
}
