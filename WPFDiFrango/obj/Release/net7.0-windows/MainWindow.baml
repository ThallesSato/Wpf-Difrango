   M S B A M L   `   `   `  ���� F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango      WPFDiFrango.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WPFDiFrango       � Title$  
MainWindow��$	��750��$
��1375�� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ MainGrid�� � RowDefinitions �� $��26 ��� $
��175* � � ColumnDefinitions �� $
��640* ��� $
��640* �.+��� -   $��Novo Pedido��$��1��$��80��$��2��$��
-160,0,0,0q��� -   $��	Atualizar��$��1��$��70��$��2���� -   $��Buscar cliente��$��1��$��80��$��2��$��	160,0,0,0q��� $��Center=�$��1��$��0��$
��Wrap=�$��Assados��$��Center=�$��16(��� $��Center=�$��1��$��1��$
��Wrap=�$��Fritos��$��Center=�$��16(�&   System.Windows.Controls.DataGrid  -     Name$ assados��$��0��$��2��   AutoGenerateColumns$ False��$��2��   CanUserAddRows$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Hora��
   
IsReadOnly$

 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *DataHoraPedido+ �� StringFormat$ HH:mm��  $	 Produtos��$

 True�� �� *ProdutosToString+  $	 Cliente��$

 True�� �� *Cliente.Nome+4  .System.Windows.Controls.DataGridCheckBoxColumn  $	 Marcado�� �� *	Marcado+4  .System.Windows.Controls.DataGridTemplateColumn  $	 Ações��   CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� -   $��Editar��
 � Tag �� �� -   $��Cancelar�� ��   $	 
HoraCriado��$

 True�� �� *DataHoraCriado+$ dd/MM HH:mm��  -   $ fritos��$��1��$��2��$ False��$��2��$ False��   $
	 Hora��$

 True�� �� *DataHoraPedido+$ HH:mm��  $	 Produtos��$

 True�� �� *ProdutosToString+  $	 Cliente��$

 True�� �� *Cliente.Nome+  $	 Marcado�� �� *	Marcado+  $	 Ações�� �� .R��� $ 
Horizontal=�.+��� -	   $��Editar�� �� �� -
   $��Cancelar�� ��   $	 
HoraCriado��$

 True�� �� *DataHoraCriado+$ dd/MM HH:mm��