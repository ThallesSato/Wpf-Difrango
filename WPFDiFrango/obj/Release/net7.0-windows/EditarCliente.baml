   M S B A M L   `   `   `  ���� F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango      WPFDiFrango.EditarCliente   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WPFDiFrango     ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  EditarCliente��$	��450��$	��880�� � WindowStartupLocation$ CenterScreen=�.��� .+��� $��Center=�$
��Wrap=�$��Editar Cliente��$	��Top=�$��16(�$
��Bold"��� $��Center=�$
��Wrap=�$��Histórico de Pedidos��$	��Top=�$��16(�$
��Bold"�$��0,55,0,0q��� $��Id��$
��Left=�$	��Top=�$��5,25,0,0q��� -    ��Name$ Id��$�� �� �� 	MaxLength$ 15�� �� TextWrapping$
 Wrap=�$��35��$��19��$
��Left=�$	��Top=�$��	30,28,0,0q� �� 
IsReadOnly$
 True���� $��Telefone��$
��Left=�$	��Top=�$��	75,25,0,0q�%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ Telefone��   Mask$ (00) 00000-0000��$�� ��$ 15��$
 Wrap=�$	��100��$��19��$
��Left=�$	��Top=�$��
130,28,0,0q��� $
��Nome��$
��Left=�$	��Top=�$��
240,25,0,0q��� -   $
 Nome��$
 Wrap=�$�� ��$	��200��$��19��$
��Left=�$	��Top=�$��
285,28,0,0q��� $��	Endereço��$
��Left=�$	��Top=�$��
495,25,0,0q��� -   $ Endereco��$
 Wrap=�$�� ��$	��200��$��19��$
��Left=�$	��Top=�$��
555,28,0,0q��� -   $��Editar Cliente��$
��Left=�$	��Top=�$��
765,27,0,0q�$��13(�$��90��&   System.Windows.Controls.DataGrid  -     Name$ pedidos��	   AutoGenerateColumns$	 False��$��2��
   CanUserAddRows$
 False��$��0,80,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   
IsReadOnly$
 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ DataHoraPedido��$
 True�� �� *DataHoraPedido+ �� StringFormat$ dd/MM/yy HH:mm��  $ Produtos��$
 True�� �� *ProdutosToString+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Marcado��$
 True�� �� *	Marcado+  $ DataHoraCriado��$
 True�� �� *DataHoraCriado+$ dd/MM/yy HH:mm��  $ Deletado��$
 True�� �� *
Deletado+