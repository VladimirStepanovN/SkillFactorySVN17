# 17.6.6. �������� (HW-03)

>> �������� ���� ������� ������������ ���� �� ������� 4 � ������������ � ��������� ����������-����������.

```
public class Account
{
   // ��� ������� ������
   public string Type { get; set; }
  
   // ������ ������� ������
   public double Balance { get; set; }
  
   // ���������� ������
   public double Interest { get; set; }
}
```

```
public static class Calculator 
{ 
   // ����� ��� ������� ���������� ������
   public static void CalculateInterest(Account account) 
   { 
       if (account.Type == "�������") 
       { 
           // ������ ���������� ������ �������� �������� �� �������� �����
               account.Interest = account.Balance * 0.4;
 
               if (account.Balance < 1000)
                   account.Interest -= account.Balance * 0.2;
              
               if (account.Balance >= 1000)
                   account.Interest -= account.Balance * 0.4;
       } 
       else if(account.Type == "����������") 
       { 
           // ������ ���������� ����� ����������� �������� �� �������� �����
           account.Interest = account.Balance * 0.5;
       } 
   }
} 
```