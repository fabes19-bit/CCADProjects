using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment3_3_2;

public partial class Form1 : Form
{
    private readonly BindingList<Student> _students = new BindingList<Student>();
    private readonly BindingSource _bindingSource = new BindingSource();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        SetupMonthComboBox();
        SetupGradeComboBox();
        ConfigureDataGridView();

        // Bind BindingList to BindingSource, and BindingSource to DataGridView
        _bindingSource.DataSource = _students;
        dgvStudents.DataSource = _bindingSource;

        // Seed initial sample data to demonstrate functionality immediately
        SeedSampleData();
        UpdateRecordCount();
        ClearInputFields();

        statusLabel.Text = "Application ready. Enter details to add a student or select a row to delete.";
    }

    /// <summary>
    /// Populates the month dropdown using values from the MonthOfAdmission enum.
    /// Demonstrates Enum reflection and type-safe UI binding.
    /// </summary>
    private void SetupMonthComboBox()
    {
        cmbMonth.Items.Clear();
        foreach (MonthOfAdmission month in Enum.GetValues<MonthOfAdmission>())
        {
            cmbMonth.Items.Add(month);
        }
        if (cmbMonth.Items.Count > 0)
        {
            cmbMonth.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// Populates the grade dropdown with standard letter grades.
    /// </summary>
    private void SetupGradeComboBox()
    {
        cmbGrade.Items.Clear();
        char[] grades = { 'A', 'B', 'C', 'D', 'F' };
        foreach (char g in grades)
        {
            cmbGrade.Items.Add(g);
        }
        if (cmbGrade.Items.Count > 0)
        {
            cmbGrade.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// Configures the DataGridView with explicit columns mapped to Student properties.
    /// Demonstrates DataGridView customization: headers, column alignments, and data property mapping.
    /// </summary>
    private void ConfigureDataGridView()
    {
        dgvStudents.AutoGenerateColumns = false;
        dgvStudents.Columns.Clear();

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.StudId),
            HeaderText = "Student ID",
            Name = "colStudId",
            Width = 95,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.FirstName),
            HeaderText = "First Name",
            Name = "colFirstName",
            Width = 115
        });

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.LastName),
            HeaderText = "Last Name",
            Name = "colLastName",
            Width = 115
        });

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.Address),
            HeaderText = "Address",
            Name = "colAddress",
            Width = 175
        });

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.MonthOfAdmission),
            HeaderText = "Month of Admission",
            Name = "colMonth",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Student.Grade),
            HeaderText = "Grade",
            Name = "colGrade",
            Width = 75,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    /// <summary>
    /// Seeds realistic initial data so the user can verify grid display and delete operations immediately.
    /// </summary>
    private void SeedSampleData()
    {
        _students.Add(new Student(101, "Fabian", "Rollins", "742 Evergreen Terrace", MonthOfAdmission.August, 'A'));
        _students.Add(new Student(102, "James", "Miller", "100 Main Street", MonthOfAdmission.September, 'B'));
        _students.Add(new Student(103, "Sarah", "Connor", "456 Tech Parkway", MonthOfAdmission.January, 'A'));
        _students.Add(new Student(104, "Elena", "Reyes", "88 Ocean Avenue", MonthOfAdmission.June, 'C'));
    }

    /// <summary>
    /// Operation 1: Add new records with rigorous input validation.
    /// </summary>
    private void btnAdd_Click(object? sender, EventArgs e)
    {
        // 1. Validate Student ID
        if (!int.TryParse(txtStudId.Text.Trim(), out int studId) || studId <= 0)
        {
            MessageBox.Show(
                "Please enter a valid positive integer for Student ID.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtStudId.Focus();
            txtStudId.SelectAll();
            return;
        }

        // Check for duplicate Student ID
        foreach (Student s in _students)
        {
            if (s.StudId == studId)
            {
                MessageBox.Show(
                    $"A student with ID {studId} already exists ({s.FullName}).\nEach student must have a unique Student ID.",
                    "Duplicate ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStudId.Focus();
                txtStudId.SelectAll();
                return;
            }
        }

        // 2. Validate First Name
        string firstName = txtFirstName.Text.Trim();
        if (string.IsNullOrWhiteSpace(firstName))
        {
            MessageBox.Show(
                "Please enter the student's First Name.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtFirstName.Focus();
            return;
        }

        // 3. Validate Last Name
        string lastName = txtLastName.Text.Trim();
        if (string.IsNullOrWhiteSpace(lastName))
        {
            MessageBox.Show(
                "Please enter the student's Last Name.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtLastName.Focus();
            return;
        }

        // 4. Validate Address
        string address = txtAddress.Text.Trim();
        if (string.IsNullOrWhiteSpace(address))
        {
            address = "N/A";
        }

        // 5. Validate Month of Admission (Enum)
        if (cmbMonth.SelectedItem is not MonthOfAdmission month)
        {
            MessageBox.Show(
                "Please select a valid Month of Admission.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            cmbMonth.Focus();
            return;
        }

        // 6. Validate Grade (char)
        if (cmbGrade.SelectedItem == null || !char.TryParse(cmbGrade.SelectedItem.ToString(), out char grade))
        {
            MessageBox.Show(
                "Please select a valid letter Grade.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            cmbGrade.Focus();
            return;
        }

        // Instantiate new Student record and add to BindingList
        Student newStudent = new Student(studId, firstName, lastName, address, month, grade);
        _students.Add(newStudent);

        // Select the newly added row
        int newIndex = _students.IndexOf(newStudent);
        if (newIndex >= 0 && newIndex < dgvStudents.Rows.Count)
        {
            dgvStudents.ClearSelection();
            dgvStudents.Rows[newIndex].Selected = true;
        }

        UpdateRecordCount();
        statusLabel.Text = $"Success: Added student '{newStudent.FullName}' (ID: {newStudent.StudId}) to records.";

        ClearInputFields();
        txtStudId.Focus();
    }

    /// <summary>
    /// Operation 2: Delete selected record with confirmation prompt.
    /// </summary>
    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.DataBoundItem is not Student selectedStudent)
        {
            MessageBox.Show(
                "Please select a student from the grid to delete.",
                "No Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete the student:\n\nID: {selectedStudent.StudId}\nName: {selectedStudent.FullName}\nMonth: {selectedStudent.MonthOfAdmission}\nGrade: {selectedStudent.Grade}?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (result == DialogResult.Yes)
        {
            string name = selectedStudent.FullName;
            int id = selectedStudent.StudId;

            _students.Remove(selectedStudent);
            UpdateRecordCount();
            ClearInputFields();

            statusLabel.Text = $"Record removed: Student '{name}' (ID: {id}) was deleted.";
        }
    }

    /// <summary>
    /// Resets all entry input fields to ready state.
    /// </summary>
    private void btnClear_Click(object? sender, EventArgs e)
    {
        ClearInputFields();
        statusLabel.Text = "Input fields cleared.";
        txtStudId.Focus();
    }

    /// <summary>
    /// Adds additional sample records if the user wants to test adding more items.
    /// </summary>
    private void btnSeed_Click(object? sender, EventArgs e)
    {
        int maxId = 100;
        foreach (Student s in _students)
        {
            if (s.StudId > maxId) maxId = s.StudId;
        }

        _students.Add(new Student(maxId + 1, "Marcus", "Vance", "321 College Blvd", MonthOfAdmission.March, 'B'));
        _students.Add(new Student(maxId + 2, "Chloe", "Bennett", "55 Innovation Way", MonthOfAdmission.October, 'A'));

        UpdateRecordCount();
        statusLabel.Text = $"Added 2 sample student records (IDs {maxId + 1}, {maxId + 2}).";
    }

    /// <summary>
    /// Reflects currently selected grid student in the input fields for convenience.
    /// </summary>
    private void dgvStudents_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvStudents.CurrentRow != null && dgvStudents.CurrentRow.DataBoundItem is Student student)
        {
            btnDelete.Enabled = true;
            statusLabel.Text = $"Selected: [{student.StudId}] {student.FullName} | Grade: {student.Grade} | Admitted: {student.MonthOfAdmission}";
        }
        else
        {
            btnDelete.Enabled = false;
        }
    }

    private void ClearInputFields()
    {
        txtStudId.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtAddress.Clear();
        if (cmbMonth.Items.Count > 0) cmbMonth.SelectedIndex = 0;
        if (cmbGrade.Items.Count > 0) cmbGrade.SelectedIndex = 0;
    }

    private void UpdateRecordCount()
    {
        lblCount.Text = $"Total Enrolled Students: {_students.Count} {( _students.Count == 1 ? "record" : "records" )}";
    }
}
