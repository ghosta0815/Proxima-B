using System;
using Prototype_MVCPattern.MVCPattern.Model;


namespace Prototype_MVCPattern.MVCPattern.Controller
{
    public interface IPlanetsView
    {
        void SetController(PlanetsController controller);
        void ClearGrid();
        void AddPlanetToGrid(AstronomicalBody body);
        void UpdateGridWithChangedPlanet(AstronomicalBody body);
        void RemovePlanetFromGrid(AstronomicalBody body);
        void SetSelectedBody(AstronomicalBody body);
        string getIdOfSelectedBody();

        string PlanetID { get; set; }
        string PlanetName { get; set; }
        double PlanetMass { get; set; }
        double PlanetDiameter { get; set; }
        bool CanModifyID { set; }
    }
}
