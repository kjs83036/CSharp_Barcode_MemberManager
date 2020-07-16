using KjsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberBarcode
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private string memberId;
        private Crud crud;
        private DuplicatedFunction duplicatedFunction;
        private SqlQuery sqlQuery;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 form2, string memberId, Crud crud, DuplicatedFunction duplicatedFunction, SqlQuery sqlQuery)
        {
            this.form2 = form2;
            this.memberId = memberId;
            this.crud = crud;
            this.duplicatedFunction = duplicatedFunction;
            this.sqlQuery = sqlQuery;
        }
    }
}
