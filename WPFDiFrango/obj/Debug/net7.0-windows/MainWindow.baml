   M S B A M L   `   `   `  ����F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango  5   	       WPFDiFrango.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFDiFrango     5   	     � Title$  
MainWindow��5   	   $	��758��6   $
��1366��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � -   5         �Name$ MainGrid��5
       � RowDefinitions 5   
   �� 5      $��26 �6   �� 5      $
��175* �6    � ColumnDefinitions 5   
   �� 5      $
��640* �6   �� 5      $
��640* �6   .+�5   
   �� -   5        $��Novo Pedido��5      $��1��6:   $��80��6K   $��2��6V   $��
-160,0,0,0q�6j   �� 5   
   -   5        $��	Atualizar��5      $��1��6:   $��70��6K   $��2��6V   �� 5   
   -   5        $��Buscar cliente��5      $��1��6A   $��80��6R   $��2��6]   $��	160,0,0,0q�6q   �� 5   
   $��Center=�6   $��1��61   $��0��6C   $
��Wrap=�6S   $��Assados��6g   $��Center=�6v   $��16(�6�   �� 5   
   $��Center=�6   $��1��61   $��1��6C   $
��Wrap=�6S   $��Fritos��6g   $��Center=�6u   $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ assados��5      $��0��6$   $��2��6_      AutoGenerateColumns$ False��6l   $��2��6�      CanUserAddRows$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Hora��6\   
   
IsReadOnly$

 True��6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *DataHoraPedido+ �� StringFormat$ HH:mm��6j     5      $	 Produtos��6J   $

 True��6\    6%   �� *ProdutosToString+6\     5       $	 Cliente��6F   $

 True��6W    6%   �� *Cliente.Nome+6W   4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      $	 Marcado��6E    6)   �� *	Marcado+6E   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $	 Ações��6)      CellTemplate 5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6)   .+�5&   "   �� -   5        $��Editar��5&   )   
 � Tag 6U   �� �� 5'   "   -   5        $��Cancelar��5'   )    6Y   �� 5(      5)      5+        5,      $	 
HoraCriado��6d   $

 True��6x    6%   �� *DataHoraCriado+$ dd/MM HH:mm��6x   5.        50   
   -   5        $ fritos��50      $��1��6#   $��2��6^   $ False��6k   $��2��6�   $ False��6�    51        52      $
	 Hora��6\   $

 True��6j    6%   �� *DataHoraPedido+$ HH:mm��6j     53      $	 Produtos��6J   $

 True��6\    6%   �� *ProdutosToString+6\     54      $	 Cliente��6F   $

 True��6W    6%   �� *Cliente.Nome+6W     55      $	 Marcado��6E    6)   �� *	Marcado+6E     56      $	 Ações��6)    57      �� 58      .R�59      �� $ 
Horizontal=�6)   .+�5:   "   �� -	   5        $��Editar��5:   )    6U   �� �� 5;   "   -
   5        $��Cancelar��5;   )    6Y   �� 5<      5=      5?        5@      $	 
HoraCriado��6d   $

 True��6x    6%   �� *DataHoraCriado+$ dd/MM HH:mm��6x   5B      5C      5D      