   M S B A M L   `   `   `  ����  GestionAvituallamientos:    4GestionAvituallamientos.Vista.VentanaAvituallamiento   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  VentanaAvituallamiento��5   	   $��390.889��6(   $	��525��69   .��5      � $��0,1,0.4,2.6q�6   ���	#FFEDEDED.+�5   
   �� -   5         ��Name$ labelNombre��5      $��AVITUALLAMIENTO��6%   $��
20,10,22,0q�6?   $	��Top=�6S   $��30��6k    J� RenderTransformOrigin$ 1.758,0.227&�6w   $��Center=�6�   �� 5   
   -   5        $ LabelPK��5      $��Punto kilométrico: ��6!   $
��Left=�6?   $��	20,54,0,0q�6Z   $	��Top=�6m   $��25��6�   $	��118��6�   �� 5   
   -   5         ��Name$ 	tbPuntoKm��5      $��23��6�   $��143,54,22,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   ��6%   ��  �� Path$ PuntoKilometrico� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6�   �� 5	   
   $��Persona de contacto��6   $��25��6.   $��
10,86,10,0q�6:   $	��Top=�6N   $��Center=�6f   �� 5
   
   $��Nombre:��6   $��20,128,434,0q�6"   $	��Top=�68   $ 1.731,1.365&�6P   $��23��6t   �� 5   
   -   5        $ 
tbNombrePC��5      $��23��6�   $��105,128,275,0q�6�   $
 Wrap=�6�   $	��Top=�6�   ��6&   �� $ PersonaContacto.Nombre� .  . 6�   �� 5   
   $��
Teléfono:��6   $��243,125,201,0q�6$   $	��Top=�6;   $ 1.298,0.663&�6S   �� 5   
   -   5        $ tbTel��5      $��23��6�   $��322,128,22,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $ -0.053,0.761&�6�   ��6!   �� $ PersonaContacto.Telefono� .  . 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtProductos��5      $��20,166,23,85q�6Y   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . ��6(   �� $ MaterialDisponible�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre Producto��6q      CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ Producto.Nombre�   ClipboardContentBinding 6N   Z� 6�     5      $
 Tipo��6w    .  $ 4* 6�    6%   �� $ Producto.TipoProducto� 6T   Z� 6�     5      $ Precio��6q    .  $ 4* 6�    6%   �� $ Producto.Precio� 6N   Z� 6�     5      $ Cantidad��6j   $ 4* 6|    6%   �� $ Cantidad� 6G   Z� 6|   5      �� 5   
   -   5         ��Name$ botonAdd��5      $��Añadir Productos...��6#   $��20,283,380,0q�6A   $��26��6n   $	��Top=�6z   �� 5   
   -   5        $ 	btAceptar��5      $��ACEPTAR��6$   $
��Left=�66   $��407,304,0,0q�6Q   $	��Top=�6f   $��88��6~   $��34��6�   6�   �� 5   
   -	   5        $ bttBorrarProductos��5      $��Borrar productos��6-   $
��Left=�6H   $��143,283,0,0q�6c   $	��Top=�6x   $	��100��6�   $��26��6�   6�   5      5      