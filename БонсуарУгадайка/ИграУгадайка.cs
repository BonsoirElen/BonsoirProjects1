using System;
using �������������;

namespace ���������������
{
    class ������������
    {
        static int Main ()
        {
            Main4();
            return 0;
        }



        static int Main4 ()
        {
            //  ������� ���������� ��� ����� ����.
            int �����������;
            int ���������������������;


            //  ������� ��������� ���������� �����.
            ��������������������� = ��������������.���������(1, 100);
            ��������������.�����������("��������� ������� �����.");


        ���������:
            //  ����� �� ������ ������ ������� �����.
            ��������������.�����������("�����! ������ ����� �� 1 �� 100!");
            ����������� = ��������������.�����������();

            if (����������� > 100)
            {
                ��������������.�����������("�� ���� ������� ������� �����. � ����� �� ���������.");
                goto ���������;
            }
            if (����������� <= 0)
            {
                ��������������.�����������("�� ���� ������� ��������� �����. �� ���, ���������?");
                goto ���������;
            }


            //  ����� �� ����� ����� ���������
            ��������������.�����������("���� �������� ����� " + ���������������������);


            ��������������.�����();
            return 0;
        }



        static int Main2 ()
        {
            int A;                                      //  ������� �������� ���������� �
            int B;
            string �����;                               //  ������� ��������� ���������� �����

            ��������������.�����������("���� ������� �����!");   //  ������ ��������� �� �������

            B = ��������������.���������(1, 100);       //  ����������� ����. ����� �� 1 �� 100

            ��������������.�����������("������ �����:");    //  ������ ��������� �� �������
            ����� = ��������������.������������();          //  ��������� ��������� �� ������� 

            A = Int32.Parse(�����);                     //  ����������� ����� � ����� + ����������� ���������� A

            ��������������.�����������("��������: " + "� = " + A + ", " + "B = " + B);
            ��������������.�����();

            return 0;                                   //  ����� �� ������� ������� ��������� (������� Main)

        }

        static int Main3()
        {
            int A;                                      //  ������� �������� ���������� �
            int B;
            string �����;                               //  ������� ��������� ���������� �����

            Console.WriteLine("���� ������� �����!");   //  ������ ��������� �� �������
            Random ������������������ = new Random();   //  ������� ������� ����������� ����. ����� (����� ������������)

            B = ������������������.Next(1, 100 + 1);    //  ����������� ����. ����� �� 1 �� 100

            Console.WriteLine("������ �����:");         //  ������ ��������� �� �������
            ����� = Console.ReadLine();                 //  ��������� ��������� �� ������� + ����������� ���������� A

            A = Int32.Parse(�����);                     //  ����������� ����� � �����

            Console.WriteLine("��������: " + "� = " + A + ", " + "B = " + B);
            Console.ReadLine();
            
            return 0;                                   //  ����� �� ������� ������� ��������� (������� Main)

        }
    }
}


