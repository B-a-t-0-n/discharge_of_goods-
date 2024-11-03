using DockeLib;
using DockeLib.Data;
using DockeLib.Exel;
using System.Net.Sockets;


namespace AppWindowsForm
{
    public partial class DockeForm : Form
    {
        private Docke? _docke;

        public DockeForm(Docke docke)
        {
            InitializeComponent();
            LoadData(docke);
            trackBarSpeed.Maximum = 5000;
            trackBarSpeed.Minimum = 10;
            trackBarSpeed.Value = 5000;
        }

        private void LoadData(Docke docke)
        {
            _docke = docke;
            listBoxFactories.Items.Clear();
            listBoxFactories.Items.AddRange(_docke.Factories!.ToArray());

            listBoxAgrees.Items.Clear();
            listBoxAgrees.Items.AddRange(_docke.Agrees!.ToArray());
        }

        private async void buttonCreateTable_Click(object sender, EventArgs e)
        {
            if (listBoxAgrees.SelectedItem == null || listBoxFactories.SelectedItem == null)
            {
                MessageBox.Show("Выберите фабрику и соглашение");
                return;
            }

            var agree = listBoxAgrees.SelectedItem as Agrees;
            var factory = listBoxFactories.SelectedItem as Factories;

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Книга Exel (.xlsx)|*.xlsx";
            sf.ShowDialog();
            var path = sf.FileName;

            if (path == "")
                return;

            MessageBox.Show("Началось создание файла\nнажмите 'ок' и ожидайте следуюшее сообщение");

            labelInfoLoad.Text = "идёт создание файла";
            timerAnimationLoading.Enabled = true;
            buttonCreateTable.Enabled = false;

            await CreateTable(agree, factory, path);
            labelInfoLoad.Text = "";
            buttonCreateTable.Enabled = true;
            timerAnimationLoading.Enabled = false;
        }

        private async Task CreateTable(Agrees? agree, Factories? factory, string path)
        {
            try
            {
                await _docke!.UpdateAll(agree!.uuid!, factory!.uuid!, trackBarSpeed.Value, checkBoxBuy.Checked).WaitAsync(new TimeSpan(2, 30, 0), TimeProvider.System);

                DockeTableExel grandLineTable = new DockeTableExel(_docke!);
                grandLineTable.CreateTable(path);

                MessageBox.Show("файл успешно создан");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"возникла ошибка создания файла\n\n{ex}");
            }
        }

        private void listBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFactories.SelectedItem != null)
            {
                Factories fa = (Factories)listBoxFactories.SelectedItem;
                richTextBoxInfo.Text = $"uu_id = {fa.uuid}\n\n" +
                                       $"название = {fa.name}";
            }
        }

        private void listBoxAgreements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAgrees.SelectedItem != null)
            {
                Agrees ag = (Agrees)listBoxAgrees.SelectedItem;
                richTextBoxInfo.Text = $"uu_id = {ag.uuid}\n\n" +
                                       $"название = {ag.name}";

            }
        }

        private void timerAnimationLoading_Tick(object sender, EventArgs e)
        {
            if (labelInfoLoad.Text.Where(i => i == '.').Count() < 3)
            {
                labelInfoLoad.Text += ".";
            }
            else
            {
                labelInfoLoad.Text = labelInfoLoad.Text.Trim('.');
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
