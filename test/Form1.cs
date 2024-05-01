using Microsoft.EntityFrameworkCore;
using Lab7.Entity;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private DataContext _context;
        public Form1()
        {
            InitializeComponent();
            // Ініціалізація контексту даних
            _context = new DataContext();
            // Створення бази даних, якщо вона ще не існує
            _context.Database.EnsureCreated();
        }

        // Обробник події завантаження форми
        private void Form1_Load(object sender, EventArgs e)
        {
            filmBindingSource.DataSource = _context.Film.Local.ToBindingList();
            _context.Film.Load();
        }

        // Обробник натискання кнопки додавання фільму
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Отримання даних про фільм з текстових полів форми
            string title = txtBoxTitle.Text;
            string director = txtBoxDirector.Text;
            string writer = txtBoxWriter.Text;
            string genre = txtBoxGenre.Text;

            int year;
            if (int.TryParse(txtBoxYear.Text, out year))
            {
                Film newFilm = new Film(title, director, writer, genre, year);
                _context.Film.Add(newFilm);
                _context.SaveChanges();
                filmBindingSource.DataSource = _context.Film.Local.ToBindingList();
            }
        }

        // Обробник натискання кнопки видалення фільму
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilms.SelectedRows.Count == 1)
            {
                int selectedId = (int)dataGridViewFilms.SelectedRows[0].Cells[0].Value;
                var filmToDelete = await _context.Film.FindAsync(selectedId);

                if (filmToDelete != null)
                {
                    filmBindingSource.RemoveAt(dataGridViewFilms.SelectedRows[0].Index);
                    _context.Film.Remove(filmToDelete);
                    await _context.SaveChangesAsync();
                }
            }
        }

        private void dataGridViewFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }
    }
}