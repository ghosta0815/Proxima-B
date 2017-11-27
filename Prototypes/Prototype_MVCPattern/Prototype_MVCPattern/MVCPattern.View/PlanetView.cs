using System;
using System.Windows.Forms;
using Prototype_MVCPattern.MVCPattern.Controller;
using Prototype_MVCPattern.MVCPattern.Model;

namespace Prototype_MVCPattern.MVCPattern.View
{
    public partial class PlanetView : Form, IPlanetsView
    {
        private PlanetsController _controller;

        public PlanetView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the controller of this instance
        /// </summary>
        /// <param name="controller"></param>
        public void SetController(PlanetsController controller)
        {
            _controller = controller;
        }

        /// <summary>
        /// Adds a planet to the Grid
        /// </summary>
        /// <param name="body"></param>
        public void AddPlanetToGrid(AstronomicalBody body)
        {
            string[] row = { body.ID, body.Name, body.Diameter.ToString("E3"), body.Mass.ToString("E3") };
            this.PlanetsGridView.Rows.Add(row);

        }

        /// <summary>
        /// Updates one Cell of the grid
        /// </summary>
        /// <param name="body"></param>
        public void UpdateGridWithChangedPlanet(AstronomicalBody body)
        {
            DataGridViewRow rowToUpdate = null;
            foreach (DataGridViewRow row in this.PlanetsGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == body.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null )
            {
                string[] row = { body.ID, body.Name, body.Diameter.ToString("E3"), body.Mass.ToString("E3") };
                rowToUpdate.SetValues(row);
            }
        }

        /// <summary>
        /// Removes a Planet from the List
        /// </summary>
        /// <param name="body"></param>
        public void RemovePlanetFromGrid(AstronomicalBody body)
        {
            DataGridViewRow rowToRemove = null;
            foreach (DataGridViewRow row in this.PlanetsGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == body.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null )
            {
                this.PlanetsGridView.Rows.Remove(rowToRemove);
            }
        }

        /// <summary>
        /// Returns the Id of a selected body. On Multiselect, the topmost is returned.
        /// </summary>
        /// <returns></returns>
        public string getIdOfSelectedBody()
        {
            if (this.PlanetsGridView.SelectedRows.Count > 0)
            {
                return this.PlanetsGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Clears all entries from the Planets grid View
        /// </summary>
        public void ClearGrid()
        {
            this.PlanetsGridView.Rows.Clear();
        }

        /// <summary>
        /// Sets the selected Cell in the gridview to body
        /// </summary>
        /// <param name="body"></param>
        public void SetSelectedBody(AstronomicalBody body)
        {
            foreach (DataGridViewRow row in this.PlanetsGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == body.ID)
                {
                    row.Selected = true;
                }
            }
        }



        public double PlanetMass
        {
            get
            {
                return Decimal.ToDouble(NewPlanetMass.Value);
            }

            set
            {
                NewPlanetMass.Value = Convert.ToDecimal(value);
            }
        }

        double IPlanetsView.PlanetDiameter
        {
            get
            {
                return Decimal.ToDouble(NewPlanetDiameter.Value);
            }

            set
            {
                NewPlanetDiameter.Value = Convert.ToDecimal(value);
            }
        }

        string IPlanetsView.PlanetID
        {
            get
            {
                return NewPlanetID.Text;
            }

            set
            {
                NewPlanetID.Text = value;
            }
        }

        string IPlanetsView.PlanetName
        {
            get
            {
                return newPlanetName.Text;
            }

            set
            {
                newPlanetName.Text = value;
            }
        }

        public bool CanModifyID
        {
            set
            {
                NewPlanetID.Enabled = value;
            }
        }

        private void AddNewPlanetButton_Click(object sender, EventArgs e)
        {
            _controller.AddNewBody();
        }

        private void RemovePlanetButton_Click(object sender, EventArgs e)
        {
            _controller.RemoveBody();
        }

        private void RegisterPlanetButton_Click(object sender, EventArgs e)
        {
            _controller.Save();
        }

        private void PlanetsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(PlanetsGridView.SelectedRows.Count > 0)
            {
                _controller.SelectedBodyChanged(PlanetsGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
