using Bot.Models;
using System.Collections.Generic;

namespace Bot.ViewModels
{
    public class AddingCar
    {
        public Car Car { get; set; }
        public IEnumerable<CarType> CarTypes { get; set; }
    }
}