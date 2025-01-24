using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        INSERT INTO Products (Name, Description, Price, ImageUrl) VALUES
            ('Wireless Earbuds', 'High-quality wireless earbuds with noise cancellation.', 59.99, '/images/wireless_earbuds.jpg'),
            ('Smartphone 128GB', 'Latest model smartphone with a 6.5-inch display and 128GB storage.', 699.99, '/images/smartphone.jpg'),
            ('Men''s Leather Wallet', 'Genuine leather wallet with multiple card slots.', 29.99, '/images/leather_wallet.jpg'),
            ('Women''s Running Shoes', 'Comfortable and durable running shoes for women.', 79.99, '/images/running_shoes.jpg'),
            ('Electric Kettle', '1.5L electric kettle with auto shut-off and boil-dry protection.', 24.99, '/images/electric_kettle.jpg'),
            ('LED Desk Lamp', 'Adjustable LED desk lamp with touch control and multiple brightness levels.', 39.99, '/images/desk_lamp.jpg'),
            ('Fitness Tracker', 'Waterproof fitness tracker with heart rate monitor and step counter.', 49.99, '/images/fitness_tracker.jpg'),
            ('Gaming Headset', 'Over-ear gaming headset with surround sound and noise-cancelling microphone.', 89.99, '/images/gaming_headset.jpg'),
            ('Bluetooth Speaker', 'Portable Bluetooth speaker with deep bass and 10 hours of playtime.', 39.99, '/images/bluetooth_speaker.jpg'),
            ('Ceramic Coffee Mug', '11oz ceramic coffee mug with a comfortable handle and modern design.', 12.99, '/images/coffee_mug.jpg');
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products WHERE Id BETWEEN 1 AND 10;");
        }
    }
}
