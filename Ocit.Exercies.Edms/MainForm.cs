using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ocit.Exercies.Edms.Infrastructure.Common.Commands.LoadRegistry;
using Ocit.Exercies.Edms.Infrastructure.Common.Enums;

namespace Ocit.Exercies.Edms
{
    public partial class MainForm : Form
    {
        private readonly IMediator _mediator;

        public MainForm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;
        }

        private async void SetDataSource(RegistryType type)
        {
            var query = new LoadRegestryQuery(type);

            var response = await _mediator.Send(query);

            bindingSource.DataSource = response;
            dataGridView.DataSource = bindingSource;
        }

        private void basicDocumentButton_Click(object sender, EventArgs e)
        {
            SetDataSource(RegistryType.Basic);
        }

        private void incomingDocumentButton_Click(object sender, EventArgs e)
        {
            SetDataSource(RegistryType.Incoming);
        }

    }
}