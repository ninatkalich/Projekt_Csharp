   M S B A M L   `   `   `  ����U  QCsharp_projektzaliczeniowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Csharp_projektzaliczeniowyCsharp_projektzaliczeniowy  5   	   ,    &Csharp_projektzaliczeniowy.KlienciPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Csharp_projektzaliczeniowy     5   	     � Title$  KlienciPage��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Klienci_data��5
         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6^   $��0,0,0,75q�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Imię��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *imie+  5      $ Nazwisko��6%    67   �� *
nazwisko+  5      $ Płeć��6%    63   �� *płec+  5      $ pierwsza_rejestracja��6%    6C   �� *pierwsza_rejestracja+5      �� 5   
   -   5        $��Dodaj Klienta��5      $
��Left=�6)   $��25��6D   $��
125,0,0,25q�6P   $��Bottom=�6d   $	��100��6   6�   �� 5   
   -   5        $��Edytuj Klienta��5      $
��Left=�6*   $��25��6E   $��
350,0,0,25q�6Q   $��Bottom=�6e   $	��100��6�   6�   �� 5   
   -   5        $��Usuń Klienta��5      $
��Left=�6(   $��25��6C   $��
575,0,0,25q�6O   $��Bottom=�6c   $	��100��6~   6�   5      5      