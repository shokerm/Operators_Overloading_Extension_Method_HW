using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Operators_Overloading_Extension_Method_HW
{
    public class Camp
    {
        //Field and properties
        private int id;
        public int Latitude { get; private set; }
        public int Longitude { get; private set; }
        public int NumberOfPeople { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFleshLights { get; private set; }
        private int lastCampId = 0;
        //Ctors
        public Camp(int numberOfPeople, int numberOfTents, int numberOfFleshLights)
        {
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLights;
            id = lastCampId;
            lastCampId++;
        }
        public Camp(int latitude, int longitude, int numberOfPeople, int numberOfTents, int numberOfFleshLights) : this(numberOfPeople, numberOfTents, numberOfFleshLights)
        {
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLights;
            id = lastCampId;
            lastCampId++;


        }

        //opertaors overload

        public static bool operator ==(Camp camp1, Camp camp2)
        {
            return camp1.id == camp2.id;
        }
        public static bool operator !=(Camp camp1, Camp camp2)
        {
            return !(camp1.id == camp2.id);
        }
        public static bool operator >(Camp camp1, Camp camp2)
        {
            if (camp1.NumberOfPeople == camp2.NumberOfPeople)
                return false;
            return camp1.NumberOfPeople > camp2.NumberOfPeople;
        }
        public static bool operator <(Camp camp1, Camp camp2)
        {
            if (camp1.NumberOfPeople == camp2.NumberOfPeople)
                return false;
            return !(camp1.NumberOfPeople > camp2.NumberOfPeople);
        }
        public static Camp operator +(Camp camp1, Camp camp2)
        {
            return new Camp(camp1.NumberOfPeople + camp2.NumberOfPeople,
                camp1.NumberOfTents + camp2.NumberOfTents,
                 camp1.NumberOfFleshLights + camp2.NumberOfFleshLights);













        }

        //overrides
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public override bool Equals(object? obj)
        {
            if ((obj as Camp).id == this.id)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return id;
        }




        public static int CreateRandomLong()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}

