using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace DominoTournament
{
    class GamingClass
    {
        private readonly int FirstNum;
        private readonly int NumberOfGames;
        private readonly string FolderPath;
        private readonly Tour CurrentTour;

        public GamingClass(int firstNum, int numberOfGames, string folderPath, Tour currentTour)
        {
            FirstNum = firstNum;
            NumberOfGames = numberOfGames;
            FolderPath = folderPath;
            CurrentTour = currentTour;
            ReplaceFiles();
            StartPair();
        }

        private void StartPair()
        {
            var compiler = CodeDomProvider.CreateProvider("CSharp");

            string[] filesToCompile =
            {
                @"DominoC\MFPlayer.cs",
                @"DominoC\MSPlayer.cs",
                @"DominoC\MTable.cs",
            };

            var parameters = new CompilerParameters()
            {
                CompilerOptions = "/target:library",
                GenerateInMemory = true,
                IncludeDebugInformation = false
            };

            CompilerResults results = compiler.CompileAssemblyFromFile(parameters, filesToCompile);
            if (results.Errors.Capacity != 0)
            {
                foreach (var r in results.Errors)
                {
                    r.ToString();
                }
            }
            object[] arguments = new object[1];
            arguments[0] = true;
            int[] arrRes = (int[]) results.CompiledAssembly.GetType("DominoC.MTable").GetMethod("StartOneGame").Invoke(null, arguments);
        }

        private void ReplaceFiles()
        {
            File.Delete(@"DominoC\MFPlayer.cs");
            File.Delete(@"DominoC\MSPlayer.cs");

            string fullPath = FolderPath + @"\" + CurrentTour.Participants[FirstNum].Name + ".cs";
            string newFileName = "MFPlayer.cs";
            File.Copy(fullPath, @"DominoC\" + newFileName);

            fullPath = FolderPath + @"\" + CurrentTour.Participants[FirstNum + 1].Name + ".cs";
            newFileName = "MSPlayer.cs";
            File.Copy(fullPath, @"DominoC\" + newFileName);
        }
    }
}
