   M S B A M L   `   `   `  ����F  BWPFDiFrango, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFDiFrangoWPFDiFrango  5   	       WPFDiFrango.EditarCliente   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFDiFrango     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  EditarCliente��5	   	   $	��450��6   $	��880��6,    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��Editar Cliente��6E   $	��Top=�6[   $��16(�6s   $
��Bold"�6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��Histórico de Pedidos��6E   $	��Top=�6a   $��16(�6y   $
��Bold"�6�   $��0,55,0,0q�6�   �� 5   
   $��Id��6   $
��Left=�6   $	��Top=�68   $��5,25,0,0q�6P   �� 5   
   -   5         ��Name$ Id��5      $�� ��6    �� 	MaxLength$ 15��6&    �� TextWrapping$
 Wrap=�65   $��35��6I   $��19��6T   $
��Left=�6`   $	��Top=�6{   $��	30,28,0,0q�6�    �� 
IsReadOnly$
 True��6�   �� 5   
   $��Telefone��6   $
��Left=�6#   $	��Top=�6>   $��	75,25,0,0q�6V   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ Telefone��5   4      Mask$ (00) 00000-0000��6   $�� ��6F   $ 15��6N   $
 Wrap=�6]   $	��100��6q   $��19��6}   $
��Left=�6�   $	��Top=�6�   $��
130,28,0,0q�6�   �� 5   
   $
��Nome��6   $
��Left=�6   $	��Top=�6:   $��
240,25,0,0q�6R   �� 5   
   -   5        $
 Nome��5      $
 Wrap=�6    $�� ��64   $	��200��6<   $��19��6H   $
��Left=�6U   $	��Top=�6p   $��
285,28,0,0q�6�   �� 5   
   $��	Endereço��6   $
��Left=�6#   $	��Top=�6>   $��
495,25,0,0q�6V   �� 5   
   -   5        $ Endereco��5      $
 Wrap=�6$   $�� ��68   $	��200��6@   $��19��6L   $
��Left=�6X   $	��Top=�6s   $��
555,28,0,0q�6�   �� 5   
   -   5        $��Editar Cliente��5      $
��Left=�6*   $	��Top=�6E   $��
765,27,0,0q�6]   $��13(�6q   $��90��6   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ pedidos��5      	   AutoGenerateColumns$	 False��6O   $��2��6k   
   CanUserAddRows$
 False��6|   $��0,80,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6<      
IsReadOnly$
 True��6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6H     5      $ DataHoraPedido��6g   $
 True��6    6%   �� *DataHoraPedido+ �� StringFormat$ dd/MM/yy HH:mm��6     5      $ Produtos��6J   $
 True��6\    6%   �� *ProdutosToString+6\   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Marcado��6E   $
 True��6W    6)   �� *	Marcado+6W     5      $ DataHoraCriado��6g   $
 True��6    6%   �� *DataHoraCriado+$ dd/MM/yy HH:mm��6     5       $ Deletado��6F   $
 True��6Y    6)   �� *
Deletado+6Y   5"      5#      5$      