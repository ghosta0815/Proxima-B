using System;
using System.Collections;
using Prototype_MVCPattern.MVCPattern.Controller;
using Prototype_MVCPattern.MVCPattern.View;
using Prototype_MVCPattern.MVCPattern.Model;

namespace Prototype_MVCPattern
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            PlanetView view = new PlanetView();
            view.Visible = false;

            IList planets = new ArrayList();

            planets.Add(new AstronomicalBody("Earth", "1", 1.0, 1.0));
            planets.Add(new AstronomicalBody("Mercury", "2", 0.382, 0.06));
            planets.Add(new AstronomicalBody("Venus", "3", 0.949, 0.92));
            planets.Add(new AstronomicalBody("Mars", "4", 0.532, 0.11));

            PlanetsController controller = new PlanetsController(view, planets);
            controller.LoadView();
            view.ShowDialog();

        }
    }
}
