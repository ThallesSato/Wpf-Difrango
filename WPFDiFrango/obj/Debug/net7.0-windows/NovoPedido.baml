   M S B A M L   `   `   `  ����F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango  5   	       WPFDiFrango.NovoPedido   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFDiFrango     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Novo pedido��5	   	   $	��500��6   $	��288��6*    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�6.   .��5      �  � ColumnDefinitions 5   
   �� 5      $��63 �6   �� 5      $	��237 �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��400 �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��Cliente��6E   $	��Top=�6T   $��16(�6l   $
��Bold"�6z   $��3��6�   $��0��6�   $��	-30,0,0,0q�6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��Pedido��6E   $	��Top=�6S   $��16(�6k   $
��Bold"�6y   $��	-30,0,0,0q�6�   $��3��6�   $��1��6�   �� 5   
   $��	Telefone*��6   $
��Left=�6$   $	��Top=�6?   $��
0,22.5,0,0q�6W   $��0��6k   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ Telefone��5   4      Mask$ (00) 00000-0000��6   $�� ��6F    �� 	MaxLength$ 15��6N    �� TextWrapping$
 Wrap=�6t   $	��115��6�   $��19��6�   $��	2,26,0,55q�6�   $��1��6�   $
��Left=�6�   6�   �� 5   
   -   5        	 ��Name$	 combotel��5      $��2,48,0,0q�6|   $
��auto��6�   $��1��6�   $��2��6�   
 K� ZIndex$
 1��6�   $	��Top=�6�   $y�Hidden=�6�   $
��Left=�6�   �� 5   
   $��Nome*��6   $
��Left=�6    $	��Top=�6;   $��0,45,0,0q�6S   $��0��6e   �� 5   
   -   5         ��Name$
 Nome��5      $
 Wrap=�6    $�� ��64   $	��200��6<   $��19��6H   $��	2,48,0,33q�6T   $��1��6   $
��Left=�6�   6�   �� 5   
   -   5        $	 	combonome��5      $��2,71,0,0q�6~   $
��auto��6�   $��1��6�   $��2��6�   $
 1��6�   $	��Top=�6�   $y�Visible=�6�   $
��Left=�6�   �� 5   
   $��	Endereço��6   $
��Left=�6#   $	��Top=�6>   $��
0,67.5,0,0q�6V   $��0��6j   �� 5   
   -   5        $ Endereco��5      $
 Wrap=�6$   $�� ��68   $	��200��6@   $��19��6L   $��	2,71,0,10q�6X   $��1��6k   $
��Left=�6{   �� 5    
   $
��Data��6   $
��Left=�6   $��24��6:   $��0��6F   $��1��6V   $��	0,0,0,331q�6c     5!   
   -   5        $
 Data��5!   /   $ 
00/00/0000��6   $ 10��6=   $
 Wrap=�6L   $�� ��6`   $��70��6h   $��19��6s   $��1��6   $��1��6�   $
��Left=�6�   $��	0,3,0,333q�6�   �� 5"   
   $
��Hora��6   $
��Left=�6   $��24��6:   $��1��6F   $��1��6V   $��
89,0,0,331q�6c     5#   
   -   5        $
 Hora��5#   *   $ 00:00��6   $ 5��68   $
 Wrap=�6F   $�� ��6Z   $��70��6b   $��19��6m   $��1��6y   $��1��6�   $
��Left=�6�   $��130,3,0,333q�6�   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ gridProduto��5$      $��1��6(   $��2��6d   $��
6,53,35,78q�6x   $��1��6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Produto��6F      
IsReadOnly$
 True��6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Produto.Nome+6W     5'      $	 Qtd��6D    6%   �� *
Quantidade+6D   5)      �� 5*   
   -	   5        $��Adicionar produto��5*      $
��Left=�6-   $��	6,328,0,0q�6H   $��25��6[   $��1��6g   $	��Top=�6t   $	��120��6�   $��2��6�   
 � Tag 6�   �� 6�   �� 5+   
   -
   5        $��Adicionar pedido��5+      $
��Left=�6,   $��145,328,0,0q�6G   $��25��6\   $��1��6h   $	��Top=�6u   $	��120��6�   $��2��6�    6�   �� 6�   5-      5.      