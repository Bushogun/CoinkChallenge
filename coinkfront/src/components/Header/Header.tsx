function Header() {
  return (
    <header className="sticky top-0 z-50 px-4 py-6 transition-all duration-500">
      <div className="max-w-7xl mx-auto" style={{ margin: "auto" }}>
        <div
          className="rounded-full items-center px-8 py-3 hidden md:flex transition-all duration-500 ease-in-out backdrop-blur-[20px] bg-gray-900/20 saturate-150 "
          style={{ minHeight: "64px" }}
        >
          <div className="flex-1 flex justify-center space-x-12">
            <a
              href="/"
              className="font-medium transition-colors duration-300 hover:opacity-60 text-white"
            >
              Create
            </a>
            </div>
            <div className="flex-1 flex justify-center">
                <a href="/">
                  <img
                  loading="lazy"
                    src="/JOLogo.png"
                    width={30}
                    height={30}
                    alt="Logo"
                    className="hover:opacity-80 transition-opacity"
                    style={{ color: 'transparent' }}
                    />
                </a>
                <div className="flex-1 flex justify-center space-x-12">
                        <a
              href="/UserList"
              className="font-medium transition-colors duration-300 hover:opacity-60 text-white"
            >
              UserList
            </a>
            </div>
          </div>
        </div>
      </div>
    </header>
  );
}

export default Header;
