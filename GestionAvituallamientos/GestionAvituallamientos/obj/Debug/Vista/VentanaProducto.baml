   M S B A M L   `   `   `  ����  GestionAvituallamientos3    -GestionAvituallamientos.Vista.VentanaProducto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  VentanaProducto��5   	   $��422.408��6"   $��457.436��63   .��5      � $��0,0,4.2,-0.6q�6   ���	#FFEDEDED � RowDefinitions 5   
   �� 5      �� 5	      $��0* �6   .+�5   
   �� -   5         ��Name$ tbNombreProducto��5      $��101,40,16.6,0q�6,    �� TextWrapping$
 Wrap=�6C   $��23��6�   $	��Top=�6�   ��6{   �� *Nombre+ �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6�   �� 5   
   -   5         ��Name$ cbTipoProducto��5      $��100,79,17,0q�6+   $	��Top=�6@   ��6}   �� *listaProductos+ �� SelectedItem 6�   �� *P.TipoProducto+ .  . �� 5   
   -   5        $ tbPrecioProducto��5      $��100,118,16.6,0q�6,   $
 Wrap=�6D   $��23��6�   $	��Top=�6�   ��6|   �� *Precio+ .  . 6�   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��	10,40,0,0q�6=   $��75��6P   $��23��6[   $	��Top=�6g   �� 5   
   $��Tipo: ��6   $
��Left=�6!   $��	10,79,0,0q�6<   $��75��6O   $��26��6Z   $	��Top=�6f   �� 5   
   $��Precio: ��6   $
��Left=�6#   $��
10,118,0,0q�6>   $��75��6R   $��23��6]   $	��Top=�6i   �� 5   
   $��ALTA PRODUCTOS��6   $
��Left=�6)   $��25��6D   $��20,0,0,0q�6P   $	��Top=�6b   $	��375��6z   $��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgProductosDadosDeAlta��5      $��20,192,16.8,93.4q�6_   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . ��63   ��  �� Path$ ListaProductos�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Header$ Nombre producto��6~      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ Nombre�   ClipboardContentBinding 6[   Z� 6�     5       .  $
 Tipo��6�   $ 3* 6�    6%   �� $ TipoProducto� 6a   Z� 6�     5       .  $ Precio��6~   $ 3* 6�    6%   �� $ Precio� 6[   Z� 6�   5      �� 5   
   -   5         ��Name$ AddProducto��5      $��Añadir��6&   $
��Left=�67   $��355,154,0,0q�6R   $	��Top=�6g   $��75��6   $��24��6�   6�   �� 5   
   -   5        $ bttModificarProducto��5      $��Modificar Producto��6/   $
��Left=�6L   $��
22,321,0,0q�6g   $	��Top=�6{   $	��123��6�   $��24��6�   6�   �� 5   
   -   5        $ bttBorrarProducto��5      $��Borrar Producto��6,   $
��Left=�6F   $��161,321,0,0q�6a   $	��Top=�6v   $	��103��6�   $��24��6�   6�   �� 5   
   -   5         ��Name$ labelMensaje��5      $�� ��6&   $
��Left=�61   $��
17,350,0,0q�6L   $	��Top=�6`   $	��420��6x   
���  ��$��43��6�   �� 5   
   -	   5        $��aceptar��5      $
��Left=�6#   $��356,321,0,0q�6>   $	��Top=�6S   $��75��6k   6v   5      5       