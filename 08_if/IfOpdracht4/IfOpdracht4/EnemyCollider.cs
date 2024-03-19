namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            return (enemy.flying == true || enemy.incoporial == true || enemy.subterranian == true);//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            return (enemy.flying == true || enemy.incoporial == true || enemy.subterranian == true || enemy.swimmer == true);//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}