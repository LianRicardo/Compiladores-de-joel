using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Diagnostics;
using System.Management;

namespace Proyecto_Compiladores2
{
  public partial class Form1 : Form
  {
    bool ChangeTextFlag;
    private dynamic Compilador;
    bool IsOpened = false;
    string path = Directory.GetCurrentDirectory();
    Stream s;
    string filetxt;
    string filename;
    public Form1()
    {
      InitializeComponent();
      clear();
      string dllpath = "";
      for (int i = 0; i < 4; i++)
      {
        path = Directory.GetParent(path).ToString();
      }
      //aqui hize esto debido a que en mi carpeta se metio en mis repos de git y no me daba la ruta correcta
      dllpath = Path.Combine(path, "Proyecto_Compiladores2\\DLL\\Binaries\\");
      bool candebug = System.Diagnostics.Debugger.IsAttached;
      if (Environment.Is64BitProcess)
      {
        if (candebug)
        {
          dllpath += "x64\\Debug\\Compilador.dll";
        }
        else
        {
          dllpath += "x64\\Release\\Compilador.dll";
        }
      }
      else
      {
        if (candebug)
        {
          dllpath += "x86\\Debug\\Compilador.dll";
        }
        else
        {
          dllpath += "x86\\Release\\Compilador.dll";
        }
      }
      var dll = Assembly.LoadFile(dllpath);
      var DLLType = dll.GetType("Compilador.Manager");
      Compilador = Activator.CreateInstance(DLLType);
    }

    private void Txt_TextChanged(object sender, EventArgs e)
    {
      if (txt.Text == "")
      {
        ChangeTextFlag = false;
      }
      else
      {
        ChangeTextFlag = true;
      }
    }
    private void clear()
    {
      IsOpened = false;
      ChangeTextFlag = false;
      path = Directory.GetCurrentDirectory();
      txt.ResetText();
      output.ResetText();
      datatoken.DataSource = null;
      simbols.DataSource = null;
    }

    private void FileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void NewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (ChangeTextFlag == true)
      {
        if (MessageBox.Show("Desea guardar prro", "SaveFileAs", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          if (true == IsOpened)
          {
            save();
          }
        }
        else
        {
          clear();
        }
      }
      else
      {
        clear();
      }
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ventana2.InitialDirectory = path;
      if (ChangeTextFlag == true)
      {
        if (MessageBox.Show("Desea guardar prro", "SaveFileAs", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          SaveAs();
          if (this.ventana2.ShowDialog() == DialogResult.OK)
          {
            if ((s = ventana2.OpenFile()) != null)
            {
              filename = ventana2.FileName;
              filetxt = File.ReadAllText(filename);
              txt.Text = filetxt;
              IsOpened = true;
            }
          }
          else
          {
            IsOpened = false;
            output.Text = "eee prro";
          }
        }
        else
        {
          if (this.ventana2.ShowDialog() == DialogResult.OK)
          {
            if ((s = ventana2.OpenFile()) != null)
            {
              filename = ventana2.FileName;
              filetxt = File.ReadAllText(filename);
              txt.Text = filetxt;
              IsOpened = true;
            }
          }
          else
          {
            IsOpened = false;
            output.Text = "eee prro";
          }
        }
      }
      else
      {
        if (this.ventana2.ShowDialog() == DialogResult.OK)
        {
          if ((s = ventana2.OpenFile()) != null)
          {
            filename = ventana2.FileName;
            filetxt = File.ReadAllText(filename);
            txt.Text = filetxt;
            IsOpened = true;
          }
        }
        else
        {
          IsOpened = false;
          output.Text = "eee prro";
        }
      }
    }

    private void save()
    {
      if (ChangeTextFlag == false)
      {
        MessageBox.Show("NO HAY TEXTO QUE GUARDAR", "QUIERE GUARDAR Y NO HAY NADA", MessageBoxButtons.OK);
      }
      else
      {
        if (true == IsOpened)
        {
          File.WriteAllText(path, txt.Text);
        }
        else
        {
          SaveAs();
        }
      }
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      save();
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveAs();
    }
    private void SaveAs()
    {
      ventana.InitialDirectory = path;
      if (ventana.ShowDialog() == DialogResult.OK)
      {
        File.WriteAllText(ventana.FileName, txt.Text);
        IsOpened = true;
        path = Path.GetFullPath(ventana.FileName);
        filetxt = ventana.FileName;
      }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (ChangeTextFlag == true)
      {
        if (MessageBox.Show("Desea guardar ", "SaveFileAs", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          if (true == IsOpened)
          {
            save();
          }
          else
          {
            SaveAs();
          }
        }
        else
        {
          this.Close();
        }
      }
      else
      {
        this.Close();
      }
    }

    private void CompileProgramToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //Crea una string para obtener los datos del compileprogram
      String[] compile = Compilador.compileProgram(txt.Text);
      //crea un int y hace que le devuelva el primer arroba en el arrleglo
      int firstand = Array.IndexOf(compile, "@");
      // crea un string de errores y toma la primera cadena separada por el primer arroba
      String[] error = compile.Take(firstand).ToArray();
      //hace un chequeo de la longitud de la cadena de error para ver si hubo errores
      if (error.Length > 0)
      {
        output.Lines = error;
      }
      //si no hubo dice un mensaje de compilacion
      else
      {
        output.Text = "========== Compile: succeeded ==========";
      }
      //aqui hago un sting de tokens para obtener los tokens y hace un skip(este skip se hace con la posicion de la primera @ + 1 porque es donde comienza la cadena) para inorar la otra parte de la cadena
      String[] tokens = compile.Skip(firstand + 1).ToArray();
      //limpia el datagridview
      datatoken.Rows.Clear();
      //hace una busqueda de strings en tokens
      foreach (string token in tokens)
      {
        //tokeniza o separa esos string para luego ponerlos en la datagirdview
        var values = token.Split('\t');
        datatoken.Rows.Add(values);
      }
      datatoken.AutoResizeColumns();
    }

    private void SaveTokensAsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void SaveSymbolsAsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void AiuuuudaaaaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Si quieres saber la gramatica ve a el link de abajo", "Ayuda con la gramatica", MessageBoxButtons.OK) == DialogResult.OK)
      {
        output.Text = "https//www.googledocs.com/bnf.txt";
      }
    }

    private void Datatoken_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Output_TextChanged(object sender, EventArgs e)
    {

    }

    private void Simbols_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
