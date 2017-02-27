using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Reflection;
using System.Collections;

namespace nonPredictiveParser
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        private char[,] first_sets, follow_sets,grammer;
        private string[,] rules;
        private OpenFileDialog file;
        private TextReader text_reader;
        private string sets;
        private int set_counter_x=0, set_counter_y=0;
        private int total_production_rules=0;
        private int[,] table ;
        private char[] rows, cols;
        Stack s = new Stack();
        public Form1()
        {
            InitializeComponent();
            // initialization of Array or Table
            rules = new string[5,6];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rules[i, j] = "";
                }
            }
            first_sets = new char[10,10];
            follow_sets = new char[10,10];
            grammer = new char[10, 10];
            table = new int[10,10];
            rows = new char[10];
            cols = new char[10];
            // Table Initialization
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = new int();
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Non Predictive Parser";
        }

        private void create_table()
        {
            int first_set_index = -1,follow_set_index = -1;
            for (int i = 0; i < total_production_rules; i++)
            {
                // ith production rule is being used here 
                // so passing ith first char to find in the first sets
                // which returns the index for first set
                char rule;
                if (i == total_production_rules-1)
                {
                    rule = grammer[i, 1];
                    int table_row_index = get_table_row_index(rule);
                    int table_col_index = get_table_cols_index(grammer[i,0]);
                    if(table_col_index != -1 && table_row_index != -1)
                    {
                        table[table_col_index,table_row_index] = i+1;
                        break;
                    }
                }
                if(check_rule_for_null(i))
                {
                    continue;
                }
                rule = grammer[i, 0];
                first_set_index = get_firstset_index(rule);
                for (int num_terminal = 1;num_terminal<10 ; num_terminal++)
                {
                    if (first_sets[first_set_index, num_terminal] != 0)
                    {
                        int table_row_index = get_table_row_index(first_sets[first_set_index,num_terminal]);
                        int table_col_index = get_table_cols_index(rule);
                        if (table_col_index != -1 && table_row_index != -1)
                        {
                            table[table_col_index, table_row_index] = i+1;
                        }
                    }
                }   
                if (find_null_in_first_sets(first_set_index))
                {
                    follow_set_index = get_followset_index(rule);
                    for (int num_terminal = 1; num_terminal < 10; num_terminal++)
                    {
                        if (follow_sets[follow_set_index, num_terminal] != 0)
                        {
                            int table_row_index = get_table_row_index(follow_sets[follow_set_index,num_terminal]);
                            int table_col_index = get_table_cols_index(rule);
                            if (table_col_index != -1 && table_row_index != -1)
                            {
                                table[table_col_index, table_row_index] = i+2;
                            }
                        }
                    }
                }
            }

        }

        bool check_rule_for_null(int row)
        {
            if (grammer[row, 1] == '~')
                return true;
            return false;
        }

        bool find_null_in_first_sets(int row)
        {
            for (int i = 0; i < 10; i++)
            {
                if (first_sets[row, i] == '~')
                {
                    return true;
                }
            }
            return false;
        }

        int get_table_row_index(char ch)
        {
            for (int i = 0; i < 10; i++)
            {
                if (rows[i] == ch)
                    return i;
            }
            for (int i = 0; i < 10; i++)
            {
                if (rows[i] == 110)
                    return i;
            }
            return -1;
            
        }

        int get_table_cols_index(char ch)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cols[i] == ch)
                    return i;
            }
            return -1;
        }

        private int get_firstset_index(char terminal)
        {
            for (int i = 0; i < 10; i++)
            {
                if (first_sets[i, 0] == terminal)
                    return i;
            }
            return -1;
        }

        private int get_followset_index(char terminal)
        {
            for (int i = 0; i < 10; i++)
            {
                if (follow_sets[i, 0] == terminal)
                    return i;
            }
            return -1;
        }

        int row_index = 0;

        void define_rows()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (!exists(first_sets[i, j]) && first_sets[i,j]!= 0 && first_sets[i,j]!='~')
                    {
                        rows[row_index++] = first_sets[i, j];
                    }
                    if (!exists(follow_sets[i, j]) && follow_sets[i,j]!= 0 && follow_sets[i,j]!= '~')
                    {
                        rows[row_index++] = follow_sets[i, j];
                    }
                }
            }
        }

        bool exists(char ch)
        {
            for (int i = 0; i < 10; i++)
            {
                if (rows[i] == ch)
                    return true;
            }
            return false;
        }

        int column_index = 0;

        void define_cols()
        {
            for (int i = 0; i < total_production_rules; i++)
            {
                if (!exists_in_cols(grammer[i, 0]))
                {
                    cols[column_index++] = grammer[i, 0];
                }
            }
        }

        bool exists_in_cols(char ch)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cols[i] == ch)
                    return true;
            }
            return false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //create_table();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_grammer_browse_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "Text Files(*.txt)|*.txt";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_grammer_file.Text = file.FileName.ToString();
                read_file();
                define_cols();
                define_rows();
                create_table();
            }
        }

        private void read_file()
        {
            text_reader = new StreamReader(file.FileName);
            string str = text_reader.ReadLine();
            while (str != null)
            {
                build_sets(str);
                str = text_reader.ReadLine();
            }
            text_reader.Close();
        }

        void build_sets(string str)
        {
            if (str == "first_sets")
            {
                set_counter_x = 0;
                set_counter_y = 0;
                sets = "first_sets";
                return;
            }
            if(str == "follow_sets")
            {
                set_counter_x = 0;
                set_counter_y = 0;
                sets = "follow_sets";
                return;
            }
            if( str == "grammer")
            {
                set_counter_x = 0;
                set_counter_y = 0;
                sets = "grammer";
                return;
            }
            if (sets == "first_sets")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '-' || str[i] == '>' || str[i] == ',')
                    {
                        continue;
                    }
                    else
                    {
                        first_sets[set_counter_x, set_counter_y++] = str[i];
                    }
                }
                set_counter_x++;
                set_counter_y = 0;
                lst_box_first_sets.Items.Add(str.ToString());
            }
            else if (sets == "follow_sets")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '-' || str[i] == '>' || str[i] == ',')
                    {
                        continue;
                    }
                    else
                    {
                        follow_sets[set_counter_x, set_counter_y++] = str[i];
                    }
                }
                set_counter_x++;
                set_counter_y = 0;
                lst_box_follow_sets.Items.Add(str.ToString());
            }
            else if (sets == "grammer")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '-' || str[i] == '>')
                    {
                        continue;
                    }
                    else
                    {
                        grammer[set_counter_x, set_counter_y++] = str[i];
                    }
                }
                set_counter_x++;
                set_counter_y = 0;
                total_production_rules++;
                lst_box_grammer.Items.Add(str.ToString());
            }
        }

        private void algorithm(string str)
            {
            str += "$";
            int pointer = 0;
            s.Clear();
            s.Push("$");
            //============= NOde =============
            TreeNode node = new TreeNode("$");
            tree_view.Nodes.Add(node);
            tree_view.SelectedNode = node;
            // =================================
            char top_value = grammer[0, 0];
            s.Push(grammer[0, 0].ToString());

            while (top_value != '$')
            {

                 if (top_value == '~')
                {
                    tree_view.SelectedNode = tree_view.SelectedNode.Parent;
                    s.Pop();
                    string ch = s.Pop().ToString();
                    top_value = char.Parse(ch);
                    s.Push(ch); 
                }
                else if (top_value == str[pointer] && top_value == '$')
                {
                    // Successfully Terminated
                    int correct = int.Parse(lbl_correct_input.Text);
                    correct++;
                    lst_box_output.Items.Add("Correct");
                    lbl_correct_input.Text = correct.ToString();
                    return;
                }
                else if ((top_value == str[pointer] || top_value == 'n') && !isNonTerminal(top_value))
                {
                    // ============== NODE ==============
                    node = new TreeNode(top_value.ToString());
                    tree_view.SelectedNode.Nodes.Add(node);
                    tree_view.SelectedNode = node.Parent;
                    // ==================================
                    s.Pop();
                    string ch = s.Pop().ToString();
                    top_value = char.Parse(ch);
                    s.Push(ch);
                    pointer++;
                }
                else if (isNonTerminal(top_value))
                {
                    int table_row_index = get_table_row_index(str[pointer]);
                    int table_col_index = get_table_cols_index(top_value);
                    int rule_num = table[table_col_index, table_row_index];
                    string rule_string = get_rule(rule_num - 1);
                    if (rule_string == "")
                    {
                        // Error Exist
                        int errors = int.Parse(lbl_incorrect_input.Text);
                        errors++;
                        lst_box_output.Items.Add("Incorrect");
                        lbl_incorrect_input.Text = errors.ToString();
                        return;
                    }
                    else
                    {
                        // ================== NODE ==============
                        node = new TreeNode(top_value.ToString());
                        tree_view.SelectedNode.Nodes.Add(node);
                        tree_view.SelectedNode = node;
                        // ======================================
                        s.Pop();
                        for (int i = rule_string.Length; i > 0; i--)
                        {
                            top_value = rule_string[i - 1];
                            s.Push(rule_string[i - 1]);
                        }
                    }
                }
                else
                {
                    int errors = int.Parse(lbl_incorrect_input.Text);
                    errors++;
                    lst_box_output.Items.Add("Incorrect");
                    lbl_incorrect_input.Text = errors.ToString();
                    return;
                }
            }
            int correct1 = int.Parse(lbl_correct_input.Text);
            correct1++;
            lst_box_output.Items.Add("Correct");
            lbl_correct_input.Text = correct1.ToString();
            return;

        }///

        string get_rule(int rule)
        {
            if (rule == -1)
                return "";
            string str = "";
            for (int i = 1; i < 10; i++)
            {
                if(grammer[rule,i] != 0)
                    str += grammer[rule, i];
            }
            return str;
        }

        bool isNonTerminal(char ch)
        {
            for (int i = 0; i < total_production_rules; i++)
            {
                if (grammer[i, 0] == ch)
                {
                    return true;
                }
            }
            return false;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_input_browse_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "Text Files(*.txt)|*.txt";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_input_file.Text = file.FileName.ToString();
                read_input();
            }
        }

        void read_input()
        {
            text_reader = new StreamReader(file.FileName);
            string str = text_reader.ReadLine();
            while (str != null)
            {
                algorithm(str);
                lst_box_input.Items.Add(str);
                str = text_reader.ReadLine();
            }
            text_reader.Close();
        }

        private void selectGrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_grammer_browse_Click(sender, e);
        }

        private void selectInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_input_browse_Click(sender, e);
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            txt_grammer_file.Text = "";
            txt_input_file.Text = "";
            tree_view.Nodes.Clear();
            lst_box_first_sets.Items.Clear();
            lst_box_follow_sets.Items.Clear();
            lst_box_grammer.Items.Clear();
            lst_box_input.Items.Clear();
            lst_box_output.Items.Clear();
            lbl_correct_input.Text = "0";
            lbl_incorrect_input.Text = "0";
            total_production_rules = 0;
            row_index = 0;
            column_index = 0;
            s.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = 0;
                    first_sets[i, j] = '\0' ;
                    follow_sets[i, j] = '\0';
                    grammer[i, j] = '\0';
                }
                rows[i] = '\0';
                cols[i] = '\0';
            }
        }


    }
}
