using ReaLTaiizor.Controls;
using System;
using System.Windows.Forms;

namespace GestionAgraria.Controls
{
    public partial class UCPaginator : UserControl
    {
        private int _currentPage = 1;
        private int _totalPages = 1;
        private const int PageSize = 1;

        public event EventHandler<int>? PageChanged;

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value >= 1 && value <= _totalPages)
                {
                    _currentPage = value;
                    UpdateDisplay();
                    PageChanged?.Invoke(this, _currentPage);
                }
            }
        }

        public int TotalPages
        {
            get => _totalPages;
            set
            {
                _totalPages = Math.Max(1, value);
                if (_currentPage > _totalPages)
                {
                    _currentPage = _totalPages;
                }
                UpdateDisplay();
            }
        }

        public static int GetPageSize() => PageSize;

        public UCPaginator()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblPageInfo.Text = $"Página {_currentPage} de {_totalPages}";
            btnPrevious.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
            btnFirst.Enabled = _currentPage > 1;
            btnLast.Enabled = _currentPage < _totalPages;

            // Siempre visible, sin importar el número de páginas
            this.Visible = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                CurrentPage = _currentPage - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                CurrentPage = _currentPage + 1;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurrentPage = _totalPages;
        }

        public void Reset()
        {
            _currentPage = 1;
            UpdateDisplay();
        }

        public static int CalculateTotalPages(int totalItems)
        {
            return (int)Math.Ceiling((double)totalItems / PageSize);
        }
    }
}
