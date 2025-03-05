using GrandLineLib.Data;
using GrandLineLib;
using GrandLineLib.Exel;

namespace AppWindowsForm
{
    public partial class GrandLineForm : Form
    {
        private GrandLine? _grandLine;

        public GrandLineForm()
        {
            InitializeComponent();
            trackBarSpeed.Maximum = 20000;
            trackBarSpeed.Minimum = 100;
            trackBarSpeed.Value = 20000;
        }

        private async void buttonCreateTable_Click(object sender, EventArgs e)
        {
            if (listBoxAgreements.SelectedItem == null || listBoxBranches.SelectedItem == null)
            {
                MessageBox.Show("Выберите точку отгрузки и договор");
                return;
            }

            var agreement = listBoxAgreements.SelectedItem as Agreement;
            var branch = listBoxBranches.SelectedItem as Branche;
            var numberOfObjects = trackBarSpeed.Value;

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

            await CreateTable(agreement, branch, path, numberOfObjects);
            labelInfoLoad.Text = "";
            buttonCreateTable.Enabled = true;
            timerAnimationLoading.Enabled = false;
        }

        private async Task CreateTable(Agreement? agreement, Branche? branch, string path, int numberOfObjects)
        {
            try
            {
                await _grandLine!.FullLoadingUpdatingOfTables(agreement!.id_1c, branch!.id_1c, numberOfObjects);

                GrandLineTableExel grandLineTable = new GrandLineTableExel(_grandLine!);
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
            if (listBoxBranches.SelectedItem != null)
            {
                Branche br = (Branche)listBoxBranches.SelectedItem;
                richTextBoxInfo.Text = $"Код 1c = {br.code_1c}\n\n" +
                                       $"название = {br.name}\n\n" +
                                       $"адрес = {br.address}\n\n" +
                                       $"Комментарий к точке отгрузки = {br.description}";
            }
        }

        private void listBoxAgreements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAgreements.SelectedItem != null)
            {
                Agreement ag = (Agreement)listBoxAgreements.SelectedItem;
                richTextBoxInfo.Text = $"Код 1c = {ag.code_1c}\n\n" +
                                       $"название = {ag.name}\n\n" +
                                       $"Список доп. соглашений = {string.Join(" ", ag.additional_agreements!)}\n";

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

        private async void GrandLineForm_Load(object sender, EventArgs e)
        {
            _grandLine = new GrandLine("ca53919db52e201246b7d2a7f5b73753");

            await _grandLine.InitializeAsync();

            listBoxBranches.Items.Clear();
            listBoxBranches.Items.AddRange(_grandLine.Branches!.ToArray());

            listBoxAgreements.Items.Clear();
            listBoxAgreements.Items.AddRange(_grandLine.Agreements!.ToArray());
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
