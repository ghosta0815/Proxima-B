using System;
using System.Collections;
using Prototype_MVCPattern.MVCPattern.Model;

namespace Prototype_MVCPattern.MVCPattern.Controller
{
    public class PlanetsController
    {
        IPlanetsView _view;
        IList _astronomicalBodys;
        AstronomicalBody _selectedBody;

        public PlanetsController(IPlanetsView view, IList bodys)
        {
            _view = view;
            _astronomicalBodys = bodys;
            view.SetController(this);
        }

        public IList astronomicalBodys
        {
            get { return ArrayList.ReadOnly(_astronomicalBodys); }
        }

        private void updateDetailView(AstronomicalBody body)
        {
            _view.PlanetName = body.Name;
            _view.PlanetDiameter = body.Diameter;
            _view.PlanetMass = body.Mass;
            _view.PlanetID = body.ID;
        }

        private void updateBody(AstronomicalBody body)
        {
            body.Name = _view.PlanetName;
            body.Diameter = _view.PlanetDiameter;
            body.Mass = _view.PlanetMass;
            body.ID = _view.PlanetID;
        }

        public void LoadView()
        {
            _view.ClearGrid();
            foreach(AstronomicalBody body in _astronomicalBodys)
            {
                _view.AddPlanetToGrid(body);
            }

            _view.SetSelectedBody((AstronomicalBody)_astronomicalBodys[0]);

        }

        public void SelectedBodyChanged(string selectedBodyId)
        {
            foreach (AstronomicalBody body in this._astronomicalBodys)
            {
                if (body.ID == selectedBodyId)
                {
                    _selectedBody = body;
                    updateDetailView(body);
                    _view.SetSelectedBody(body);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }

        public void AddNewBody()
        {
            _selectedBody = new AstronomicalBody("", "", 0, 0);
            this.updateDetailView(_selectedBody);
            this._view.CanModifyID = true;
        }

        public void RemoveBody()
        {
            string id = this._view.getIdOfSelectedBody();
            AstronomicalBody bodyToRemove = null;

            if (id != "")
            {
                foreach (AstronomicalBody body in this._astronomicalBodys)
                {
                    if (body.ID == id)
                    {
                        bodyToRemove = body;
                        break;
                    }
                }

                if (bodyToRemove != null)
                {
                    int newSelectedIndex = this._astronomicalBodys.IndexOf(bodyToRemove);
                    this._astronomicalBodys.Remove(bodyToRemove);
                    this._view.RemovePlanetFromGrid(bodyToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < _astronomicalBodys.Count)
                    {
                        this._view.SetSelectedBody((AstronomicalBody)_astronomicalBodys[newSelectedIndex]);
                    }
                }
            }
        }

        public void Save()
        {
            updateBody(_selectedBody);
            if (!this._astronomicalBodys.Contains(_selectedBody))
            {
                this._astronomicalBodys.Add(_selectedBody);
                this._view.AddPlanetToGrid(_selectedBody);
            }
            else
            {
                this._view.UpdateGridWithChangedPlanet(_selectedBody);
            }
            _view.SetSelectedBody(_selectedBody);
            this._view.CanModifyID = false;
        }
    }
}
