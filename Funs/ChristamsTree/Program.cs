// Merry Christamas Tree by Codaza


using System.Media;
using ChristamsTree;


MerryChristmasTree MCTree = new MerryChristmasTree();
SoundPlayer sp = new SoundPlayer(@"d:\Programming\MyGBProjects\MyEduCSProjects\Funs\ChristamsTree\JB_cut.wav");
sp.Play();
Thread.Sleep(500);
MCTree.ShowTree();
Console.ReadKey();