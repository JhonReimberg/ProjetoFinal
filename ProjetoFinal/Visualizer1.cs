using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ProjetoFinal
{
    // TODO: Adicionar o seguinte na definição de SomeType para exibir este visualizador durante depuração de instâncias de SomeType:
    // 
    //  [DebuggerVisualizer(typeof(Visualizer1))]
    //  [Serializable]
    //  public class SomeType
    //  {
    //   ...
    //  }
    // 
    /// <summary>
    /// Um Visualizador para SomeType.  
    /// </summary>
    public class Visualizer1 : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            // TODO: Obter o objeto para o qual exibir um visualizador.
            //       Converte o resultado de objectProvider.GetObject() 
            //       para o tipo do objeto sendo visualizado.
            object data = (object)objectProvider.GetObject();

            // TODO: Exibir sua visão do objeto.
            //       Substituir displayForm com seu próprio Controle ou Formulário personalizado.
            using (Form displayForm = new Form())
            {
                displayForm.Text = data.ToString();
                windowService.ShowDialog(displayForm);
            }
        }

        // TODO: Adicione o seguinte ao seu código de teste para testar o visualizador:
        // 
        //    Visualizer1.TestShowVisualizer(new SomeType());
        // 
        /// <summary>
        /// Testa o visualizador pela sua hospedagem fora do depurador.
        /// </summary>
        /// <param name="objectToVisualize">O objeto a exibir no visualizador.</param>
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(Visualizer1));
            visualizerHost.ShowVisualizer();
        }
    }
}
