   M S B A M L   `   `   `  ����  GestionAvituallamientos=    7GestionAvituallamientos.Vista.VentaListaProductosDeAlta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  VentaListaProductosDeAlta��5   	   $��266.4��6+   $��400.8��6:   .��5      � ���	#FFEDEDED$
��Left=�6"   $��
0,0,0,-0.2q�6=   $	��394��6Q   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$" dataGridProductosDisponibles��5      $��88��69   $��
10,57,10,0q�6�   $	��Top=�6�      AutoGenerateColumns .     
IsReadOnly . ��6E   ��  �� Path$ Logica.ListaProductos� �� SelectedItem 6x   �� $&  ProductoAvituallamiento.Producto�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Header$ Nombre��6~   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 3* 6�   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� $ Nombre�   ClipboardContentBinding 6[   Z� 6�     5	       .  $
 Tipo��6�   $	 3* 6�   
 6%   �� $ TipoProducto� 6a   Z� 6�     5
       .  $ Precio��6~   $	 3* 6�   
 6%   �� $ Precio� 6[   Z� 6�   5      �� 5   
   $��PRODUCTOS DISPONIBLES��6   $��26��60   $��10,10,9.6,0q�6<   $	��Top=�6Q   $��Center=�6i   �� 5   
   -   5         ��Name$ btAddProducto��5      $	��ADD��6(   $
��Left=�66   $��324,187,0,0q�6Q   $	��Top=�6f   $��47��6~   $��30��6�   6�   �� 5   
   -   5         ��Name$ 
tbCantidad��5      $
��Left=�6^   $��23��6y   $��158,160,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��49��6�    J� RenderTransformOrigin$ 0.894,0.503&�6�   ��6&   �� $&  ProductoAvituallamiento.Cantidad�6�   �� 5   
   $��Introduce la cantidad��6   $
��Left=�60   $��
10,160,0,0q�6K   $	��Top=�6_   $��23��6w   $	��133��6�   5      5      