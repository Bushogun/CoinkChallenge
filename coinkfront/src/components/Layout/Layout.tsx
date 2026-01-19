import type { ReactNode } from 'react';

type LayoutProps = {
  children?: ReactNode;
};

const Layout = ({ children }: LayoutProps) => {
    return (
        <div className='w-full min-h-screen flex flex-col ' style={{ fontFamily: '"Poppins", sans-serif'}}>
            { children }
        </div>
    )
}

export default Layout