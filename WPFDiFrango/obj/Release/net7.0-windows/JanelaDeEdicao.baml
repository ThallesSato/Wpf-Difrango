   M S B A M L   `   `   `  ���� F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango       WPFDiFrango.JanelaDeEdicao   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WPFDiFrango     ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  Editar pedido��$	��500��$	��288�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $��63 ��� $	��237 � � RowDefinitions �� $	��100 ��� $	��400 �.+��� $��Center=�$
��Wrap=�$��Cliente��$	��Top=�$��16(�$
��Bold"�$��3��$��0��$��	-30,0,0,0q��� $��Center=�$
��Wrap=�$��Pedido��$	��Top=�$��16(�$
��Bold"�$��	-30,0,0,0q�$��3��$��1���� $��	Telefone*��$
��Left=�$	��Top=�$��
0,22.5,0,0q�$��0��%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ Telefone��   Mask$ (00) 00000-0000��$�� �� �� 	MaxLength$ 15�� �� 
IsReadOnly$
 True��	 �� TextWrapping$
	 Wrap=�$	��115��$��19��$��	2,26,0,55q�$��1��$
��Left=��� -   $��Ver cliente��$��1��$��0��$��80��$��20��$��96,25,10,55q��� $��Nome*��$
��Left=�$	��Top=�$��0,45,0,0q�$��0���� -   
 ��Name$

 Nome��$
	 Wrap=�$�� ��$	��200��$��19��$��	2,48,0,33q�$
 True��$��1��$
��Left=��� $��	Endereço��$
��Left=�$	��Top=�$��
0,67.5,0,0q�$��0���� -   $
 Endereco��$
	 Wrap=�$�� ��$	��200��$��19��$��	2,71,0,10q�$
 True��$��1��$
��Left=��� $	��Id:��$
��Left=�$��24��$��0��$��1��$��	0,0,0,332q��� -    ��Name$ PedidoId��$��Id��$
��Left=�$��24��$��0��$��1��$��17,22,0,354q��� $��Data/Hora Criado:��$
��Left=�$��24��$��1��$��1��$��
0,22,0,354q��� -   $ 
DataCriado��$��Id��$
��Left=�$��24��$��1��$��1��$��102,22,0,354q��� $
��Data��$
��Left=�$��24��$��0��$��1��$��
0,45,0,331q�  -   $
 Data��$ 
00/00/0000��$
	 Wrap=�$�� ��$��70��$��19��$��1��$��1��$
��Left=�$��
0,48,0,333q��� $
��Hora��$
��Left=�$��24��$��1��$��1��$��89,45,0,331q�  -   $
 Hora��$ 00:00��$
	 Wrap=�$�� ��$��70��$��19��$��1��$��1��$
��Left=�$��130,48,0,333q�&   System.Windows.Controls.DataGrid  -	     Name$ gridProduto��$��1��$��2��$��
6,81,35,78q�$��1��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Produto��   
IsReadOnly$
 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Produto.Nome+  $	 Qtd�� �� *
Quantidade+�� -
   $��Adicionar produto��$
��Left=�$��	6,328,0,0q�$��25��$��1��$	��Top=�$	��120��$��2��
 � Tag �� �� -   $��Atualizar pedido��$
��Left=�$��145,328,0,0q�$��25��$��1��$	��Top=�$	��120��$��2�� �� 