using programersFunction.codingtestPractice;
using programersFunction.codingtestPractice.Level1;
using programersFunction.codingtestPractice.Level2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programersFunction.codingtestPractice.Meister;
using programersFunction.codingtestPractice._2021_BackEndDevMat;
using programersFunction.Monthly_Code_Challenge;

namespace programersMain

{

    class Program
    {

        static void Main(string[] args)
        {

            //배달 
            Delivery delivery = new Delivery();
            //int n = 5;
            //int[,] road = { { 1, 2, 1 }, { 2, 3, 3 }, { 5, 2, 2 }, { 1, 4, 2 }, { 5, 3, 1 }, { 5, 4, 2 } };
            //int k = 3;
            int n = 6;
            int k = 4;
            int[,] road = { { 1, 2, 1 }, { 1, 3, 2 }, { 2, 3, 2 }, { 3, 4, 3 }, { 3, 5, 2 }, { 3, 5, 3 }, { 5, 6, 1 } };
            int result = delivery.solution(n,road,k); 

            //괄호 회전하기 
            //bracketTrun bracketTrun = new bracketTrun();
            //string s = "[](){}";
            //int result = bracketTrun.solution(s);

            // N으로 표현 
            //NExpression nExpression = new NExpression();
            //int n = 2;
            //int number = 11;
            //int result = nExpression.solution(n, number);

            // Test 2
            //Test2 test2 = new Test2();
            //int rows = 3;
            //int columns = 3;
            ////int[,] queries = { { 1, 1, 2, 2 },{ 1, 2, 2, 3 },{ 2, 1, 3, 2 },{ 2, 2, 3, 3 }};
            //int[,] queries = { { 1, 1, 3, 3 }};
            //int[] result = test2.solution(rows, columns, queries);

            // Test 1 
            //int[] lottos = { 44, 1, 0, 0, 31, 25 };
            //int[] winNum = { 31, 10, 45, 1, 6, 19 };
            //Test1 test1 = new Test1();
            //int[] result = test1.solution(lottos, winNum);

            // 프로그래머스 게임 맵 최단거리 
            //GameMap gameMap = new GameMap();
            //int[,] maps = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
            //int answer = gameMap.solution(maps);

            // 프로그래머스 데모 테스트
            //BackEndTestDemo backEndTestDemo = new BackEndTestDemo();
            //int[,] v = { { 1, 4 }, { 3, 4 }, { 3, 10 } };
            //var result = backEndTestDemo.solution(v);

            // 레벨2 타겟넘버 
            //TargetNumber targetNumber = new TargetNumber();
            //int[] numbers = { 1, 1, 1, 1, 1 };
            //int target = 3;
            //int result = targetNumber.solution2(numbers, target);

            // 월간코드 챌린지 
            //Triangular_snail triangular_Snail = new Triangular_snail();
            //int n = 10;
            //int[] result = triangular_Snail.solution(n);

            //레벨2 스킬트리
            //SkillTree SkillTree = new SkillTree();
            //string skill = "CBD";
            //string[] skill_trees = { "BACDE", "CBADF", "AECB", "BDA" };
            //int answer = SkillTree.solution(skill, skill_trees);
            //2

            //string skill1 = "CBD";
            //string[] skill_trees1 = { "CAD" };
            //int answer1 = SkillTree.solution(skill1, skill_trees1);
            //0

            //string skill2 = "CBD";
            //string[] skill_trees2 = { "AEF", "ZJW" };
            //int answer2 = SkillTree.solution(skill2, skill_trees2);
            //2

            //string skill3 = "REA";
            //string[] skill_trees3 = { "REA", "POA" };
            //int answer3 = SkillTree.solution(skill3, skill_trees3);
            ////1

            //string skill4 = "CBDK";
            //string[] skill_trees4 = { "CB", "CXYB", "BD", "AECD", "ABC", "AEX", "CDB", "CBKD", "IJCB", "LMDK" };
            //int answer4 = SkillTree.solution(skill4, skill_trees4);
            ////4

            //string skill5 = "BDC";
            //string[] skill_trees5 = { "AAAABACA" };
            //int answer5 = SkillTree.solution(skill5, skill_trees5);
            ////0

            //string skill6 = "CBD";
            //string[] skill_trees6 = { "C", "D", "CB", "BDA" };
            //int answer6 = SkillTree.solution(skill6, skill_trees6);
            //2

            //레벨2 다리를 지나는 트럭 
            //Truct_Passing_Bridge truct_Passing_Bridge = new Truct_Passing_Bridge();
            //int bridge_length = 2;
            //int weight = 10;
            //int[] truck_weights = { 7, 4, 5, 6 };
            //int result = truct_Passing_Bridge.solution(bridge_length, weight, truck_weights);

            //레벨2 큰수 만들기
            //Create_Large_Number create_Large_number = new Create_Large_Number();
            //string num = "4177252841";
            //int k = 4;
            //string answer1 = create_Large_number.Failsolution(num, k);
            //string answer2 = create_Large_number.Failsolution2(num, k);
            //string answer3 = create_Large_number.Anothersolution(num, k);
            //string answer4 = create_Large_number.solution(num, k);

            //nhn 3번 문자열처리   
            //RG(B(2G))->RG(B(GG)) RG(BGBG)->RGBGGGBGG
            // R(G(B)R)) -> R(GBR)->RGRBRR
            //nhn_stringOperation nhn_StringOperation = new nhn_stringOperation();
            //string RGB = "2(B(GG))";
            ////string RGB = "R(G(B)R)";
            //string result = nhn_StringOperation.sulotion(RGB);

            //레벨1 예산
            //lv1_budge lv1_Budge = new lv1_budge();
            //int[] input = { 1, 3, 2, 5, 4 };
            //int budge = 9;
            //int result = lv1_Budge.solution(input, budge);

            //레벨1 제일 작은 수 제거하기 
            //lv1_deleteLowest lv1_DeleteLowest = new lv1_deleteLowest();
            //int[] arr = {-1,-1,-1,-1,-1};
            //lv1_DeleteLowest.solution(arr);

            //레벨1 3진법 뒤집기 
            //lv1_ternary lv1_Ternary = new lv1_ternary();
            //izt n = 1;
            //int result = lv1_Ternary.solution(n);

            //레벨1 두 숫자 뽑아서 더하기 
            //lv1_ChoiceAndPlus choiceAndPlus = new lv1_ChoiceAndPlus();
            //int[] number = { 2, 1, 3, 4, 1 };
            //choiceAndPlus.solution(number);

            //레벨1 소수 찾기 
            //lv1_primeNumber Lv1_primeNumber = new lv1_primeNumber();
            //int n = 5;
            //int answer = Lv1_primeNumber.solution(n);

            //레벨1 카펫 
            //Level2 level = new Level2();
            //int brown = 8;
            //int yellow = 1;
            //int[] result = level.solution(brown, yellow);

            //레벨1 이상한 문자열 
            //lv1_StrangeString Lv1_StrangeString = new lv1_StrangeString();
            //string s = "HELLOW my brother";
            //string answer = Lv1_StrangeString.solution(s);

            //레벨1 탑욕법 체육복
            //int n = 5;
            //int[] lost = new int[] { 2, 4 };
            //int[] reserve = new int[] { 1, 3, 5 };
            //lv1_Greedy_gymClothes Lv1_Greedy_GymClothes = new lv1_Greedy_gymClothes();
            //int answer = Lv1_Greedy_GymClothes.solution(n, lost, reserve);

            //레벨1 k번째 수
            //lv1_kNumber Lv1_KNumber = new lv1_kNumber();
            //int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
            //int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            //int[] answer = Lv1_KNumber.solution(array, commands);

            //레벨1 문자열 기본
            //string s = "a1234";
            //lv1_stringBasics Lv1_StringBasics = new lv1_stringBasics();
            //bool answer = Lv1_StringBasics.solution(s);

            //레벨1 모의고사
            //Lv1_mockTest lv1_MockTest = new Lv1_mockTest();
            //int[] answer = { 1, 3, 2, 4, 2 };
            //int[] result = lv1_MockTest.solution(answer);

            //레벨 2 기능개발
            //lv2_fucnDev funtion = new lv2_fucnDev();
            //int[] progresses = { 97, 93, 95, 91, 95, 94, 93, 90 };
            //int[] speeds = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //int[] result = funtion.OtherSolution(progresses, speeds); 

            //레벨1 시저암호
            //lv1_cipher Lv1_Cipher = new lv1_cipher();
            //string s = "ZB";
            //int n = 1;
            //string result = Lv1_Cipher.solution(s, n);
        }
    }
}
